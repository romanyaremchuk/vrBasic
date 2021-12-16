using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectTeleport : MonoBehaviour
{
    [SerializeField] private XRRayInteractor controllerRay;
    private GameObject objectToTeleport;

    private void Start()
    {
        objectToTeleport = Container.Instance.CarTransform;
    }

    public void TeleportObject()
    {
        RaycastHit hit;
        controllerRay.TryGetCurrent3DRaycastHit(out hit);

        Vector3 newPosition = new Vector3(hit.point.x, objectToTeleport.transform.position.y, hit.point.z);
        objectToTeleport.transform.position = newPosition;
    }
}
