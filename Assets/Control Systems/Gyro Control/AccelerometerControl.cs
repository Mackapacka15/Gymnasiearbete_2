using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerControl : MonoBehaviour
{
    private float valueX;
    public RigidBodyMovement move;
    void Update()
    {
        valueX = Input.acceleration.x;
        move.move = valueX;
    }
}
