using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveUI : MonoBehaviour
{
    [SerializeField] private GameObject setActive;
    [SerializeField] private GameObject setInactive;

    public void ChangeActiveUI()
    {
        setActive.SetActive(true);
        setInactive.SetActive(false);
    }
}
