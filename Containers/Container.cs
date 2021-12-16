using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{
    #region singleton
    private static Container _instance;
    public static Container Instance { get { return _instance; } }
    #endregion

    public GameObject CarTransform { get => carTransform; }
    public GameObject CarModel { get => carModel; }

    [SerializeField] private GameObject carTransform;
    [SerializeField] private GameObject carModel;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
