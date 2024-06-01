using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColorCommandInvoker
{
    private static Stack<ICommandColor> commandColorsHistory = new Stack<ICommandColor>();

    public static void ExecuteCommand(ICommandColor commandColor)
    {
        Debug.Log("Executing The Color Command");
        commandColor.Execute();
        commandColorsHistory.Push(commandColor);
    }

    public static void ExecuteUndo()
    {
        Debug.LogError("In execute part 1");
        Debug.Log(commandColorsHistory.Count);
        if(commandColorsHistory.Count > 0)
        {
            Debug.LogError("In execute part 2");
            ICommandColor undoCommand = commandColorsHistory.Pop();
            undoCommand.Undo();
        }
    }
}
