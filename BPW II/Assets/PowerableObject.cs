using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerableObject : MonoBehaviour
{
    public bool isPowered;

    public GameObject poweredState;
    public GameObject unpoweredState;

    public void Toggle()
    {
        isPowered = !isPowered;
        SetState(isPowered);
    }

    private void SetState(bool powered)
    {
            poweredState.SetActive(powered);
            unpoweredState.SetActive(!powered);
    }

    private void Start()
    {
        SetState(isPowered);
    }

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            Toggle();
        }
    }
}
