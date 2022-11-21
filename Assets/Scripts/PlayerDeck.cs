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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        deckSizeText.text = deck.Count.ToString();
    }

    public void drawCard()
    {
        if(deck.Count >= 1)
        {
            Card randCard = deck[Random.Range(0, deck.Count)];
            Debug.Log("played " + randCard);

            GameObject playerCard = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
            CardDisplay _cardDisplay = playerCard.GetComponent<CardDisplay>();
            if(_cardDisplay)
            {
                _cardDisplay.card = randCard;
            }
            else
            {
                Debug.Log("_cardDisplay doesn't exist");
            }
            playerCard.transform.SetParent(playerArea.transform, false);

            deck.Remove(randCard);
        }
    }
}
