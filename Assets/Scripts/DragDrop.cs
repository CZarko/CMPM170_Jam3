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
        private GameObject dropZone;
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

    // Update is called once per frame
    void Update()
    {
        if(isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        //Debug.Log("Drag Start");
        startPosition = transform.position;
        isDragging = true;

        RuntimeManager.PlayOneShot("event:/SFX/cardDraw");
    }

    public void EndDrag()
    {
        //Debug.Log("Drag End");
        isDragging = false;
        if(isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);
            cardFunctions.doEffect();
            combo.adjustCombo(1);
            deck.setCards(-1);

            Destroy(this.gameObject);
        }
        else
        {
            transform.position = startPosition;
        }

        RuntimeManager.CreateInstance("event:/SFX/cardPlay").start(); // Update to use two different sounds depending on context
    }
}