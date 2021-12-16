using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{
    [SerializeField] private GameObject wristUI;

    [SerializeField] private bool isUIActive = true;
 
    private void Start()
    {
        DisplayMenu();
    }

    public void DisplayMenu()
    {
        isUIActive = !isUIActive;
        wristUI.SetActive(isUIActive);
    }
}
