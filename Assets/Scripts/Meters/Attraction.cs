using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attraction : MonoBehaviour
{
    int attraction;
    void adjust(int adjustment)
    {
        attraction += adjustment;
        attraction = Mathf.Clamp(adjustment, 0, 100);
    }
}
