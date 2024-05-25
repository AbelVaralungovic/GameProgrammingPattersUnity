using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    public void MoveCube(Vector3 movement)
    {
        transform.position += movement;
    }
}
