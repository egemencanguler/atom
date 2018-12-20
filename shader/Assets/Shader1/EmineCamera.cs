using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmineCamera : MonoBehaviour 
{
    public Material emineMaterial;

    void Update()
    {
        Color color = GetComponent<Camera>().backgroundColor;
        emineMaterial.SetColor("_BackgroundColor",color);
    }
}
