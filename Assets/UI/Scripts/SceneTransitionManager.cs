using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransitionManager : MonoBehaviour {

    private Animator anim;

    // Awake is called when the scene is loaded
    void Awake() {
        anim = GetComponent<Animator>();
    }

    // FadeOut is called externally by scene managing scripts
    public void FadeOut() {
        anim.SetTrigger("Out");
    }

    // FadeIn is called externally by scene managing scripts
    public void FadeIn() {
        anim.SetTrigger("In");
    }

}
