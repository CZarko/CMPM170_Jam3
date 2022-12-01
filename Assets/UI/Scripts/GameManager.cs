using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private SceneTransitionManager stm;

    // Start is called before the first frame update
    void Start() {
        stm = Object.FindObjectOfType<SceneTransitionManager>();
        stm.FadeOut();
    }

}
