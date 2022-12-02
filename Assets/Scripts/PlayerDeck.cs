using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card>();
    public GameObject card;
    public GameObject playerArea;

    public TMP_Text deckSizeText;

    public int cardsInHand;
    public int drawAmount;

    public Combo combo;

    private void Awake()
    {
        drawAmount = 4;
    }
    private void Start()
    {
        combo = GameObject.FindWithTag("Combo").GetComponent<Combo>();

        cardsInHand = 0;
        deckSizeText.text = deck.Count.ToString();
        //draw 4 cards to start turn
        for(int i = 0; i < drawAmount; i++)
        {
            drawCard();
        }
        drawAmount = 2;
    }

    private void Update() {
        if(deck.Count.Equals(0)) {
          Debug.Log("check");
        }
    }

    public void takeTurn()
    {
        for (int i = 0; i < drawAmount; i++)
            drawCard();
        combo.adjustCombo(-1);
        drawAmount = 2;
    }

    public void setCards(int cards)
    {
        if (cards == -1)
            cardsInHand--;
        else
            cardsInHand = cards;
    }

    public void drawCard()
    {
        if(deck.Count >= 1)
        {
            print("DRAW!");
            cardsInHand++;
            // finds a random card in the deck
            Card randCard = deck[Random.Range(0, deck.Count)];
            Debug.Log("played " + randCard);

            // creates a copy of the card template
            GameObject playerCard = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);

            // loads the selected random card's data into the template
            CardDisplay _cardDisplay = playerCard.GetComponent<CardDisplay>();
            if(_cardDisplay)
            {
                _cardDisplay.card = randCard;
            }
            else
            {
                Debug.Log("_cardDisplay doesn't exist");
            }

            // puts the card into the player's hand
            playerCard.transform.SetParent(playerArea.transform, false);

            deck.Remove(randCard);

            // updates the UI showing how many cards remain in the deck
            deckSizeText.text = deck.Count.ToString();

            FMODUnity.RuntimeManager.PlayOneShot("event:/SFX/cardDrawMult");
        }
    }
}
