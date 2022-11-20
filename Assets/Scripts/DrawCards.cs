using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject card;
    public GameObject playerArea;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClick()
    {
        for (var i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(card, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);
        }
        
    }
}
