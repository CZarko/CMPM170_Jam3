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

    void Start()
    {
        nameText.text = card.name;
        topicText.text = card.topic;
        typeText.text = card.type;
        effectText.text = card.effect;
    }
}
