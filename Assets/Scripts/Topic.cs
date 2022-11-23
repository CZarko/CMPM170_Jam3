using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Topic : MonoBehaviour
{
    public TMP_Text topicDisplay; //the display of the conversation topic
    private void Start()
    {
        topicDisplay.text = "Video Games";
    }
    public void setTopic(string topic)
    {
        topicDisplay.text = topic;

    }

    public void nextTopic()
    {
        switch (topicDisplay.text)
        {
            case ("Video Games"):
                topicDisplay.text = "Food";
                break;
            case ("Food"):
                topicDisplay.text = "Programming";
                break;
            case ("Programming"):
                topicDisplay.text = "Video Games";
                break;
        }
    }
}
