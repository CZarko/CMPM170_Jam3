using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    private float comboMax = 5f;
    public float combo = 0;
    public Slider mSlider;

    private void Start()
    {
        mSlider.value = combo;
    }
    internal void setCombo(float adjustment)
    {
        combo = adjustment;
        combo = Mathf.Clamp(combo, 0, comboMax);
        mSlider.value = combo;
    }
}
