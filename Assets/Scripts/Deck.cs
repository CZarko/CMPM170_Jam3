using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{
    List<List<string>> cards;
    // Start is called before the first frame update
    void Start()
    {
        List<string> card1 = new List<string>{"A", "B", "C", "D", "E"};
        cards.Add(card1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
