using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText;
    public TMP_Text topicText;
    public TMP_Text typeText;
    public TMP_Text effectText;

    //booleans and integers for all the meters
    public int attractAmnt;
    public int interestAmnt;
    public int comfortAmnt;
    public int traitAmnt;

    //intrusive thought cards
    public bool halfMeters;
    public bool discardHand;
    public int drawAmnt;
    public int comboSetAmnt;

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

    void Start()
    {
        nameText.text = card.name;
        topicText.text = card.topic;
        typeText.text = card.type;
        effectText.text = card.effect;

        attractAmnt = card.attractAmnt;
        interestAmnt = card.interestAmnt;
        comfortAmnt = card.comfortAmnt;
        traitAmnt = card.traitAmnt;

        halfMeters = card.halfMeters;
        discardHand = card.discardHand;
        drawAmnt = card.drawAmnt;
        comboSetAmnt = card.comboSetAmnt;
        
        swoon = card.swoon;
        topicChange = card.topicChange;
        forceFlirt = card.forceFlirt;
        cozify = card.cozify;
        forceShare = card.forceShare;
        intrigue = card.intrigue;
        forceAsk = card.forceAsk;

        silence = card.silence;
        doubleConvoEffect = card.doubleConvoEffect;
        doubleMeter = card.doubleMeter;
        fillHand = card.fillHand;
    }
}
