using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    private SceneTransitionManager stm;
    public GameObject cw;

    // Start is called before the first frame update
    void Start() {
        stm = Object.FindObjectOfType<SceneTransitionManager>();
        stm.FadeOut();
    }

    public void Play() {
        stm.FadeIn();
        StartCoroutine(DelayPlay());

        FMODUnity.RuntimeManager.PlayOneShot("event:/MUS/menuStop");
    }

    public void Credits() {
        cw.SetActive(true);
    }

    public void CloseCredits() {
        cw.SetActive(false);
    }

    IEnumerator DelayPlay() {
      yield return new WaitForSeconds(1.5f);
      SceneManager.LoadScene("Date");
    }

}
