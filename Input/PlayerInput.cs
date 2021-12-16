using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private InputActionReference controllerActionMenu;
    [SerializeField] private InputActionReference controllerActionTeleport;

    private WristMenu wristMenu;
    private ObjectTeleport objectTeleport;

    private void Awake()
    {
        wristMenu = FindObjectOfType<WristMenu>();
        objectTeleport = FindObjectOfType<ObjectTeleport>();

        controllerActionMenu.action.performed += CallMenu;
        controllerActionTeleport.action.performed += CallObjectTeleport;
    }

    private void CallMenu(InputAction.CallbackContext obj)
    {
        wristMenu.DisplayMenu();
    }

    private void CallObjectTeleport(InputAction.CallbackContext obj)
    {
        objectTeleport.TeleportObject();
    }
}