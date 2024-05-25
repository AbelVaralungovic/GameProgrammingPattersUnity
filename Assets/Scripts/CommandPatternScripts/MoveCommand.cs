using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : ICommand
{
    CubeMover cubeMover;
    Vector3 movment;

    public MoveCommand(CubeMover cubeMover, Vector3 movment)
    {
        this.cubeMover = cubeMover;
        this.movment = movment;
    }

    public void Execute()
    {
        cubeMover.MoveCube(movment);
    }

    public void Undo()
    {
        cubeMover.MoveCube(-movment);
    }
}
