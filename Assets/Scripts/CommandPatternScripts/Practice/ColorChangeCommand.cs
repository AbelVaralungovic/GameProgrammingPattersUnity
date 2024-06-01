using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeCommand : ICommandColor
{
    private MeshRenderer meshRenderer;
    private ColorChanger colorChanger;
    private Color previousColor;

    public ColorChangeCommand(MeshRenderer renderer, ColorChanger colorChanger)
    {
        this.meshRenderer = renderer;
        this.colorChanger = colorChanger;
        this.previousColor = renderer.material.color;
    }

    public void Execute()
    {
        colorChanger.ChangeColor(meshRenderer);
    }

    public void Undo()
    {
        colorChanger.SetColor(meshRenderer, previousColor);
    }
}
