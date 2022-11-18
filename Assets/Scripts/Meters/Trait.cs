using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trait : MonoBehaviour
{
    int trait;
    void adjust(int adjustment)
    {
        trait += adjustment;
        trait = Mathf.Clamp(adjustment, 0, 100);
    }
}
