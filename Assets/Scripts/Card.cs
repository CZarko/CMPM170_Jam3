using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //see presentation slide for details on each
    public string cardName;
    public string cardTopic;
    public string cardType;
    public string cardSubtype;
    public string cardEffect;


    //sets all the values for the card
    internal void setParams(string[] cardParams)
    {
        cardName = cardParams[0];
        cardTopic = cardParams[1];
        cardType = cardParams[2];
        cardSubtype = cardParams[3];
        cardEffect = cardParams[4];
        
        foreach(string item in cardParams)
        {
            print(item);
        }
    }
}
