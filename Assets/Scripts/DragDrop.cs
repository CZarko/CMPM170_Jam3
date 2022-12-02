using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using FMODUnity;

public class DragDrop : MonoBehaviour
{

    [Header("Card Properties")]

        private bool isDragging = false;
        private bool isOverDropZone = false;
        //private GameObject dropZone;
        private GameObject dropImage;
        private Vector2 startPosition;

        private CardFunctions cardFunctions;
        private PlayerDeck deck;

        private Combo combo;

    private void Start()
    {
        cardFunctions = GetComponent<CardFunctions>();
        deck = GameObject.FindWithTag("Deck").GetComponent<PlayerDeck>();
        combo = GameObject.FindWithTag("Combo").GetComponent<Combo>();
    }

    private void Awake() {
        dropImage = GameObject.Find("DropZone").transform.Find("Drop Image").gameObject;
        dropImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "DropZone")
            isOverDropZone = true;
        //dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.name == "DropZone")
            isOverDropZone = false;
        //dropZone = null;
    }

    public void StartDrag()
    {
        //Debug.Log("Drag Start");
        dropImage.SetActive(true);
        startPosition = transform.position;
        isDragging = true;

        PlayPannedSound("event:/SFX/cardDraw");
    }

    public void EndDrag()
    {
        //Debug.Log("Drag End");
        isDragging = false;
        dropImage.SetActive(false);
        if(isOverDropZone)
        {
            //transform.SetParent(dropZone.transform, false);
            cardFunctions.doEffect();
            combo.adjustCombo(1);
            deck.setCards(-1);

            Destroy(this.gameObject);

            PlayPannedSound("event:/SFX/cardPlay");
        }
        else
        {
            transform.position = startPosition;

            PlayPannedSound("event:/SFX/cardPlace");
        }
    }

    private void PlayPannedSound(string soundEvent)
    {
        FMOD.Studio.EventInstance soundToPlay = FMODUnity.RuntimeManager.CreateInstance(soundEvent);
        FMODUnity.RuntimeManager.StudioSystem.setParameterByName("Panning Amount", transform.position.x);
        soundToPlay.start();
    }
}
