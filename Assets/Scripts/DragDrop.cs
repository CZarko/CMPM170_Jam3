using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropZone = false;
    private GameObject dropZone;
    private Vector2 startPosition;

    private CardFunctions cardFunctions;
    private PlayerDeck deck;


    private void Start()
    {
        cardFunctions = GetComponent<CardFunctions>();
        deck = GameObject.FindWithTag("Deck").GetComponent<PlayerDeck>();
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
        // Debug.Log("Drag Start");
        startPosition = transform.position;
        isDragging = true;
    }

    public void EndDrag()
    {
        // Debug.Log("Drag End");
        isDragging = false;
        if(isOverDropZone)
        {
            transform.SetParent(dropZone.transform, false);
            cardFunctions.doEffect();

            Destroy(this.gameObject);
            deck.setCards(-1);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}