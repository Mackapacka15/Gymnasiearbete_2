using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControll : MonoBehaviour
{

    public Joystick joystick;
    public RigidBodyMovement moveController;
    // Start is called before the first frame update
    // void Start()
    // {
    //     joystick = FindObjectOfType<Joystick>();
    // }

    // Update is called once per frame
    void Update()
    {
        float joyValue = joystick.Horizontal;
        Debug.Log(joyValue);
        moveController.move = joyValue;
    }
}
