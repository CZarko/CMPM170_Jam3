using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem; 

public class Input : MonoBehaviour
{
    public InputAction inputController;
    public Camera cam;

    private Vector3 mousePos;

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
    
    private void setMousePos(Vector2 pos)
    {
        mousePos = pos;
        mousePos.z = 10;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame)
            setMousePos(cam.ScreenToWorldPoint(Mouse.current.position.ReadValue()));
   
    }
    
}
