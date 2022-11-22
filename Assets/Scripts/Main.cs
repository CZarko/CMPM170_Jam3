using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Deck as a List
    public List<Card> Deck = new List<Card>();


    // Start is called before the first frame update
    void Start()
    {
        // Deck
        Debug.Log("Main Starting");
        Debug.Log("Deck Size: " + Deck.Count);     
        Debug.Log("----------> Deck: ");
        PrintDeck(ref Deck);

        // Shuffle Deck
        Debug.Log("----------> Shuffled Deck: ");
        Shuffle(ref Deck);
        PrintDeck(ref Deck);

        // Player Hand
        List<Card> PlayerHand = new List<Card>();
        Debug.Log("----------> Drawing 2 Cards for PlayerHand: ");
        DrawCards(2, ref Deck, ref PlayerHand);
        PrintDeck(ref PlayerHand);
        Debug.Log("----------> Remaining in Deck: ");
        PrintDeck(ref Deck);


        // Remove Random from PlayerHand, put back in Deck
        Debug.Log("----------> PlayerHand: ");
        PrintDeck(ref PlayerHand);
        Debug.Log("----------> Removing 1: ");
        RemoveRandom(1, ref Deck, ref PlayerHand);
        Debug.Log("----------> PlayerHand: ");
        PrintDeck(ref PlayerHand);
        Debug.Log("----------> Deck: ");
        PrintDeck(ref Deck);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ----------------------------------------------------

    // Print Deck
    public static void PrintDeck(ref List<Card> list)
    {
        foreach (Card card in list)
        {
            //Console.WriteLine(card.Name);
            Debug.Log("Card Name: " + card.name);
        }
    }

    // lister-Yates Shuffle List
    public static void Shuffle<T>(ref List<T> list)
    {
        System.Random rnd = new System.Random();
        int n = list.Count;

        while (n > 1)
        {
            int k = rnd.Next(n--);
            T temp = list[n];
            list[n] = list[k];
            list[k] = temp;
        }
    }


    // Draw Cards
    public static void DrawCards(int x, ref List<Card> deck, ref List<Card> hand)
    {
        if (x <= deck.Count)
        {
            System.Random rng = new System.Random();
            int index = 0;

            for (int i = 0; i < x; i++)
            {
                index = rng.Next(deck.Count);
                Debug.Log("Index: " + index);
                //Console.WriteLine("index: " + index);

                // Add to hand and Remove from Deck
                hand.Add(deck[index]);
                deck.RemoveAt(index);
            }
        }
    }

    // Remove Random
    public static void RemoveRandom(int x, ref List<Card> deck, ref List<Card> hand)
    {
        if (x <= hand.Count)
        {
            System.Random rng = new System.Random();
            int index = 0;

            for (int i = 0; i < x; i++)
            {
                index = rng.Next(hand.Count);
                Debug.Log("rm index: " + index);
                //Console.WriteLine("rm index: " + index);

                // Add to Deck and Remove from hand
                deck.Add(hand[index]);
                hand.RemoveAt(index);

            }
        }
    }



}
