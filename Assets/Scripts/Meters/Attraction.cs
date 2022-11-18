using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    //made public for easier debugging
    public int attraction = 0;
    void adjust(int adjustment)
    {
        attraction += adjustment;
        attraction = Mathf.Clamp(adjustment, 0, 100);
    }
}
