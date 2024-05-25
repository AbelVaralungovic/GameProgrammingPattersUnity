using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class CubeController : MonoBehaviour
{
    [SerializeField] private CubeMover cubeMover;

    [SerializeField] private Button up;
    [SerializeField] private Button down;
    [SerializeField] private Button left;
    [SerializeField] private Button right;
    [SerializeField] private Button undo;

    private void Start()
    {
        up.onClick.AddListener(() => RunMoveCommand(cubeMover, new Vector3(0f, 0f, -1f)));
        down.onClick.AddListener(() => RunMoveCommand(cubeMover, new Vector3(0f, 0f, 1f)));
        left.onClick.AddListener(() => RunMoveCommand(cubeMover, new Vector3(1f, 0f, 0f)));
        right.onClick.AddListener(() => RunMoveCommand(cubeMover, new Vector3(-1f, 0f, 0f)));
        undo.onClick.AddListener(() => CommandInvoker.UndoCommand());
    }

    private void RunMoveCommand(CubeMover cubeMover, Vector3 movement)
    {
        if (cubeMover == null)
        {
            Debug.LogError("Cube mover not assigned");
            return;
        }


        ICommand command = new MoveCommand(cubeMover, movement);
        CommandInvoker.ExecuteCommand(command);
    }
}
