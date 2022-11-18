using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem; 

public class CardMaker : MonoBehaviour, IPointerDownHandler
{
    internal GameObject cardPrefab;
    public InputAction inputController;

    //parameters to be passed to the new card
    string[] cardParams = ["a","b","c","d","e"];

    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputController.Disable();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        GameObject newCard = Instantiate(cardPrefab, new Vector2(0, 0), Quaternion.identity);
        newCard.SendMessage("setParams", cardParams);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
