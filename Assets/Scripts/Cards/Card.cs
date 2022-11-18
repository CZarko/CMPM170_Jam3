using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //see presentation slide for details on each
    public string cardName;
    public string cardType;
    public string cardSubtype;
    public string cardTopic;
    public string cardEffect;


    //sets all the values for the card
    internal void setParams(string[] cardParams)
    {
        cardName = cardParams[0];
        cardType = cardParams[1];
        cardSubtype = cardParams[2];
        cardTopic = cardParams[3];
        cardEffect = cardParams[4];
        
        foreach(string item in cardParams)
        {
            print(item);
        }
    }
}
