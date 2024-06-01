using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorController : MonoBehaviour
{
    [SerializeField] private Button changeColor;
    [SerializeField] private Button undo;

    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private ColorChanger colorChanger;

    private void Start()
    {
        changeColor.onClick.AddListener(() => RunColorChangeCommand(meshRenderer, colorChanger));
        undo.onClick.AddListener(() => ColorCommandInvoker.ExecuteUndo());
    }

    private void RunColorChangeCommand(MeshRenderer renderer, ColorChanger colorChanger)
    {
        if ( renderer != null && colorChanger != null ) {
            ColorChangeCommand command = new ColorChangeCommand( renderer, colorChanger );
            ColorCommandInvoker.ExecuteCommand( command );
        }
    }

    
}
