using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comfort : MonoBehaviour
{
    int comfort;
    void adjust(int adjustment)
    {
        comfort += adjustment;
        comfort = Mathf.Clamp(adjustment, 0, 100);
    }
}
