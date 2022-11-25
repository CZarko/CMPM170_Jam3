using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Comfort : MonoBehaviour
{
    private float comfortMax = 40f;
    public float comfort = 0;
    public Slider mSlider;

    private void Start()
    {
        mSlider.value = comfort/comfortMax;
    }
    internal void setComfort(float adjustment)
    {
        comfort = adjustment;
        comfort = Mathf.Clamp(comfort, 0, comfortMax);
        mSlider.value = comfort / comfortMax;
    }
    internal void halfComfort()
    {
        comfort = comfort / 2;
    }
}
