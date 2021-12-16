using UnityEngine;
using UnityEngine.UI;

public class ObjectRotate : MonoBehaviour
{
    [SerializeField] private Slider slider;
    private GameObject objectToRotate;

    private float previousValue;

    private void Start()
    {
        objectToRotate = Container.Instance.CarTransform;

        slider.onValueChanged.AddListener(OnSliderChanged);

        previousValue = slider.value;
    }

    void OnSliderChanged(float value)
    {
        float delta = value - previousValue;
        objectToRotate.transform.Rotate(Vector3.up * delta * 360);
        
        previousValue = value;
    }
}