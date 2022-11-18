using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{
    List<List<string>> cards;
    // Start is called before the first frame update
    void Start()
    {
        //put all the cards in the deck
        makeDeck1(); //called deck1 in case we make more starter decks
    }

    void makeDeck1()
    {
        List<string> card1 = new List<string>{"name", "conversation", "attractive", "1", "none"};
        cards.Add(card1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
