using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    public Sprite artwork;

    public string topic;
    public string type;
    public string effect;
    public string flavor;

    //booleans and integers for all the meters
    public int  attractAmnt;
    public int  interestAmnt;
    public int  comfortAmnt;
    public int  traitAmnt;

    //intrusive thought cards
    public bool halfMeters;
    public bool discardHand;
    public int  drawAmnt;
    public int  comboSetAmnt;

    //Flair cards
    public bool swoon;
    public bool topicChange;
    public bool forceFlirt;
    public bool cozify;
    public bool forceShare;
    public bool intrigue;
    public bool forceAsk;

    //Starter cards
    public bool silence;
    public bool doubleConvoEffect;
    public bool fillHand;
    public bool doubleMeter;


}
