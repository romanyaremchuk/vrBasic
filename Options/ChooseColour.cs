using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseColour : MonoBehaviour
{
    [SerializeField] private FlexibleColorPicker flexibleColorPicker;
    
    private GameObject objectToBeColoured;
    private HashSet<Material> materials;

    private void Start()
    {
        objectToBeColoured = Container.Instance.CarModel;

        flexibleColorPicker.color = Color.white;

        materials = new HashSet<Material>();
        foreach (Transform t in objectToBeColoured.transform)
        {
            Renderer r = t.GetComponent<Renderer>();
            if (r != null)
            {
                materials.Add(r.material);
            }
        }
    }

    private void Update()
    {
        foreach (var materal in materials)
        {
            materal.color = flexibleColorPicker.color;
        }
    }
}
