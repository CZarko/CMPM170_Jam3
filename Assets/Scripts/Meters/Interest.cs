using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interest : MonoBehaviour
{
    int interest;
    void adjust(int adjustment)
    {
        interest += adjustment;
        interest = Mathf.Clamp(adjustment, 0, 100);
    }
}
