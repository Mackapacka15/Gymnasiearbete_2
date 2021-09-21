using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroControl : MonoBehaviour
{   
    public Movement moveScript;
    private float move; //-1 to 1

    private Gyroscope gyro;
    private bool gyroEnabled;

    private void Start()
    {
        EnableGyro();
    }
    private void Update() {
        {

        }
    }
    private bool EnableGyro()
    {
        if(SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
            return true;
        }
        return false;
    }

    private void changeMove()
    {
        moveScript.move = move;
    }
}
