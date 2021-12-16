using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenTop : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private Animator anim;

    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderChanged);
        anim = Container.Instance.CarModel.GetComponent<Animator>();
    }

    void OnSliderChanged(float value)
    {
        anim.SetFloat("Blend", slider.value);
    }
}
