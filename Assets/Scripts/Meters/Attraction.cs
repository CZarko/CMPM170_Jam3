using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attraction : MonoBehaviour
{
    //made public for easier debugging
    internal float attraction = 0;
    private float attractionMax = 40f;
    public Slider mSlider;

    private void Start()
    {
        mSlider.value = attraction / attractionMax;
    }
    internal void adjust(int adjustment)
    {
        attraction += adjustment;
        attraction = Mathf.Clamp(attraction, 0, attractionMax);
        mSlider.value = attraction/attractionMax;
    }
}
