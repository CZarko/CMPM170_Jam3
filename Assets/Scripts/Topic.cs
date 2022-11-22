using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Topic : MonoBehaviour
{
    public TMP_Text topicDisplay; //the display of the conversation topic
    public void setTopic(string topic)
    {
        topicDisplay.text = topic;
    }

}
