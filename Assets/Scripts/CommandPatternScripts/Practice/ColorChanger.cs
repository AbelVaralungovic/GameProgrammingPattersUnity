using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public void ChangeColor(MeshRenderer meshRenderer)
    {
        meshRenderer.material.color = new Color(Random.value, Random.value, Random.value);
    }

    public void SetColor(MeshRenderer meshRenderer, Color color)
    {
        meshRenderer.material.color = color;
    }
}
