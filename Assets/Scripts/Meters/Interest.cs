using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interest : MonoBehaviour
{
    private float interestMax = 40f;
    public float interest = 0;
    public Slider mSlider;

    private void Start()
    {
        mSlider.value = interest/interestMax;
    }
    internal void adjust(int adjustment)
    {
        interest += adjustment;
        interest = Mathf.Clamp(interest, 0, interestMax);
        mSlider.value = interest/interestMax; 
    }
}
