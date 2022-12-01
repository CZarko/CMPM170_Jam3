using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class Date : MonoBehaviour
{
    public bool choiceTaken;
    public int choice = 0;
    void takeTurn()
    {
        if(!choiceTaken)
            choice = Random.Range(0, 3);
        else
            choiceTaken = false;

        switch(choice)
        {
            case 0:
                ask();
                break;
            case 1:
                share();
                break;
            case 2:
                flirt();
                break;
        }
    }
    void ask()
    {
        print("ASK");

        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/dateAsk");
    }
    void share()
    {
        print("SHARE");
        GameObject.FindWithTag("Topic").GetComponent<Topic>().nextTopic();

        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/dateShare");

    }
    void flirt()
    {
        GameObject.FindWithTag("Deck").GetComponent<PlayerDeck>().drawAmount = 4;

        FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/dateFlirt");
    }

}
