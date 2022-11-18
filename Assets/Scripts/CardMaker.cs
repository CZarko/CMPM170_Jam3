using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem; 

public class CardMaker : MonoBehaviour
{
    public GameObject cardPrefab;
    public InputAction inputController;
    public Camera cam;

    //parameters to be passed to the new card
    string[] cardParams = { "a", "b", "c", "d", "e" };

    private void OnEnable()
    {
        inputController.Enable();
    }
    private void OnDisable()
    {
        inputController.Disable();
    }
    

    private void spawnCard(string[] newParams, Vector3 spawnLocation)
    {
        GameObject newCard = Instantiate(cardPrefab, spawnLocation, Quaternion.identity);
        newCard.SendMessage("setParams", newParams);
    }
    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            mousePos.z = 10;
            spawnCard(cardParams, mousePos);
        }
    }
    
}
