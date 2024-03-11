using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    public PowerableObject power;
    public UnityEvent buttonDown;
    public UnityEvent buttonUp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //if (collider.bounds.Contains())
    }

    private void OnTriggerEnter2D(Collider2D other)
    {   
        if (!power.isPowered)
        {
            buttonDown.Invoke();
            Debug.Log("Button Down");
        }
       
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (power.isPowered)
        {
            buttonUp.Invoke();
            Debug.Log("Button Up");
        }
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("In Button");
    }
}
