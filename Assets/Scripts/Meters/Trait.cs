using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trait : MonoBehaviour
{
    private float traitMax = 30f;
    public float trait = 0;
    public Slider mSlider;

    private void Start()
    {
        mSlider.value = trait / traitMax;
    }

    internal void setTrait(float adjustment)
    {
        trait = adjustment;
        trait = Mathf.Clamp(trait, 0, traitMax);
        mSlider.value = trait / traitMax;
    }
}
