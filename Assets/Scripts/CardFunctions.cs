using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardFunctions : MonoBehaviour
{
    private CardDisplay cardDisplay;

    public Trait traitMeter;
    public Comfort comfortMeter;
    public Attraction attractMeter;
    public Interest interestMeter;
    public Combo comboMeter;
    public Date date;

    public PlayerDeck playerDeck;
    public Topic topic;

    int attractionMultipier = 1;
    int interestMultiplier = 1;
    int comfortMultiplier = 1;
    int topicMultiplier = 1;

    float traitMultiplier;



    private void Start()
    {
        cardDisplay = GetComponent<CardDisplay>();
        traitMeter = GameObject.FindWithTag("Trait").GetComponent<Trait>();
        comfortMeter = GameObject.FindWithTag("Comfort").GetComponent<Comfort>();
        attractMeter = GameObject.FindWithTag("Attraction").GetComponent<Attraction>();
        interestMeter = GameObject.FindWithTag("Interest").GetComponent<Interest>();
        comboMeter = GameObject.FindWithTag("Combo").GetComponent <Combo>();

        playerDeck = GameObject.FindWithTag("Deck").GetComponent<PlayerDeck>();
        date = GameObject.FindWithTag("DateManager").GetComponent<Date>();
        topic = GameObject.FindWithTag("Topic").GetComponent<Topic>();
    }

    private void calculateMultipliers()
    {
        float attractMultiplier = attractMeter.attraction/10f + 1;
        float interestMultiplier = interestMeter.interest / 10f + 1;
        float comfortMultiplier = comfortMeter.comfort / 10f + 1;
        float comboMultiplier = comboMeter.combo + 1;

        if (cardDisplay.topicText == topic.topicDisplay)
            topicMultiplier = 2;
        else
            topicMultiplier = 1;

        traitMultiplier = attractMultiplier + interestMultiplier + comfortMultiplier + comboMultiplier + topicMultiplier;

    }

    internal void doEffect()
    {
        calculateMultipliers();

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
            setCombo(cardDisplay.comboSetAmnt - 1);
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
        attractMeter.setAttraction(attractMeter.attraction + attractAmount * attractionMultipier);
    }
    private void addInterest(int interestAmount)
    {
        interestMeter.setInterest(interestAmount * interestMultiplier + interestMeter.interest);
    }
    private void addComfort(int comfortAmount)
    {
        comfortMeter.setComfort(comfortAmount * comfortMultiplier + comfortMeter.comfort);
    }

    private void addTrait(int traitAmount)
    {
        traitMeter.setTrait(traitAmount * traitMultiplier + traitMeter.trait);
    }

    private void halfMeters()
    {
        comfortMeter.setComfort(comfortMeter.comfort/2);
        attractMeter.setAttraction(attractMeter.attraction/2);
        interestMeter.setInterest(interestMeter.interest / 2);

    }

    private void discardHand()
    {
        GameObject[] cards = GameObject.FindGameObjectsWithTag("Card");
        foreach(GameObject card in cards)
        {
            Destroy(card);
            playerDeck.setCards(-1);
        }
        playerDeck.setCards(1);

    }

    private void draw(int drawAmount)
    {
        while(drawAmount > 0)
        {
            drawAmount--;
            playerDeck.drawCard();
        }
    }

    private void setCombo(int newCombo)
    {
        comboMeter.setCombo(newCombo);
    }

    private void swoon()
    {
        attractionMultipier = 2;
    }

    private void topicChange()
    {
        topic.nextTopic();
    }

    private void forceFlirt()
    {
        date.choice = 2;
        date.choiceTaken = true;
    }

    private void cozify()
    {
        comfortMultiplier = 2;
    }

    private void forceShare()
    {
        date.choice = 1;
        date.choiceTaken = true;
    }

    private void intrigue()
    {
        interestMultiplier = 2;
    }

    private void forceAsk()
    {
        date.choice = 0;
        date.choiceTaken = true;
    }

    private void silence()
    {
        date.choice = 4;
        date.choiceTaken = true;
    }

    private void doubleConvoEffect()
    {
        attractionMultipier = 2;
        interestMultiplier = 2;
        comfortMultiplier = 2;
    }

    private void fillHand()
    {
        while (playerDeck.cardsInHand < 6)
            playerDeck.drawCard();
            
    }

    private void doubleMeter()
    {
        attractMeter.setAttraction(attractMeter.attraction * 2);
        interestMeter.setInterest(interestMeter.interest * 2);
        comfortMeter.setComfort(comfortMeter.comfort * 2);
    }
}
