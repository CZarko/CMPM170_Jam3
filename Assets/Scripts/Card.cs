using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;
    public string cardTopic;
    public string cardType;
    public string cardSubtype;
    public string cardEffect;

    internal void setParams(string name, string topic, string type, string subtype, string effect)
    {
        cardName = name;
        cardTopic = topic;
        cardType = type;
        cardSubtype = subtype;
        cardEffect = effect;
    }
}
