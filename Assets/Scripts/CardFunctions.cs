using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFunctions : MonoBehaviour
{
    private CardDisplay cardDisplay;

    private void Start()
    {
        cardDisplay = GetComponent<CardDisplay>();
    }

    internal void doEffect()
    {

        //print(cardDisplay.attractAmnt); leaving here for reference
        if(cardDisplay.attractAmnt > 0)
        {
            addAttract(cardDisplay.attractAmnt);
        }
        if(cardDisplay.interestAmnt > 0)
        {
            addInterest(cardDisplay.interestAmnt);
        }
        if(cardDisplay.comfortAmnt > 0)
        {
            addComfort(cardDisplay.comfortAmnt);
        }
        if(cardDisplay.traitAmnt > 0)
        {
            addTrait(cardDisplay.traitAmnt);
        }
        if(cardDisplay.halfMeters)
        {
            halfMeters();
        }
        if(cardDisplay.discardHand)
        {
            discardHand();
        }
        if(cardDisplay.drawAmnt > 0)
        {
            draw(cardDisplay.drawAmnt);
        }
        if(cardDisplay.comboSetAmnt > 0)
        {
            setCombo(cardDisplay.comboSetAmnt);
        }
        if(cardDisplay.swoon)
        {
            swoon();
        }
        if(cardDisplay.topicChange)
        {
            topicChange();
        }
        if(cardDisplay.forceFlirt)
        {
            forceFlirt();
        }
        if(cardDisplay.cozify)
        {
            cozify();
        }
        if(cardDisplay.forceShare)
        {
            forceShare();
        }
        if(cardDisplay.intrigue)
        {
            intrigue();
        }
        if(cardDisplay.forceAsk)
        {
            forceAsk();
        }
        if(cardDisplay.silence)
        {
            silence();
        }
        if(cardDisplay.doubleConvoEffect)
        {
            doubleConvoEffect();
        }
        if(cardDisplay.fillHand)
        {
            fillHand();
        }
        if(cardDisplay.doubleMeter)
        {
            doubleMeter();
        }
        
    }

    private void addAttract(int attractAmount)
    {
        GameObject.FindWithTag("Attraction").GetComponent<Attraction>().adjust(attractAmount);
    }
    private void addInterest(int interestAmount)
    {
        GameObject.FindWithTag("Interest").GetComponent<Interest>().adjust(interestAmount);
    }
    private void addComfort(int comfortAmount)
    {
        GameObject.FindWithTag("Comfort").GetComponent<Comfort>().adjust(comfortAmount);
    }

    private void addTrait(int traitAmount)
    {
        GameObject.FindWithTag("Trait").GetComponent<Trait>().adjust(traitAmount);
    }

    private void halfMeters()
    {

    }

    private void discardHand()
    {

    }

    private void draw(int drawAmount)
    {

    }

    private void setCombo(int newCombo)
    {

    }

    private void swoon()
    {

    }

    private void topicChange()
    {

    }

    private void forceFlirt()
    {

    }

    private void cozify()
    {

    }

    private void forceShare()
    {

    }

    private void intrigue()
    {

    }

    private void forceAsk()
    {

    }

    private void silence()
    {

    }

    private void doubleConvoEffect()
    {

    }

    private void fillHand()
    {

    }

    private void doubleMeter()
    {

    }
}
