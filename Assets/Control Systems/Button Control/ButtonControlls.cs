using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControlls : MonoBehaviour
{
    public RigidBodyMovement movementScript;
    public float move; //-1 to 1
    public bool jump; //0 or 1
    void Update()
    {
        movementScript.move = move;
    }
    public void MoveLeft()
    {
        move = -1;
    }
    public void MoveRight()
    {
        move = 1;
    }
    public void StopMoving()
    {
        move = 0;
    }
}

