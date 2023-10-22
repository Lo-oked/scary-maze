using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public GameObject selectedObject;
    public GameObject blckvoid;


    void Start()
    {
        
    }

    
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        selectedObject.transform.position = mousePosition;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (blckvoid)
        {
            transform.position = Vector2.zero; 
        }
    }
}
