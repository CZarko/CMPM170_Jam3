using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trait : MonoBehaviour
{
    private float traitMax = 30f;
    public float trait = 0;
    public Slider mSlider;

    public int traitsLearned = 0;

    private void Start()
    {
        mSlider.value = trait / traitMax;
    }

    internal void setTrait(float adjustment)
    {
        trait = adjustment;
        if (trait >= traitMax)
            resetMeter();
        mSlider.value = trait / traitMax;
    }

    private void resetMeter()
    {
        traitsLearned ++;
        trait -= traitMax;
        mSlider.value = trait/traitMax;
        if (trait >= traitMax)
        {
            resetMeter();
        }
    }
}
