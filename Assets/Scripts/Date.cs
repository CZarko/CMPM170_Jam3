using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Date : MonoBehaviour
{
    void takeTurn()
    {
        int choice = Random.Range(0, 3);
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
    }
    void share()
    {
        print("SHARE");
    }
    void flirt()
    {
        print("FLIRT");
    }

}
