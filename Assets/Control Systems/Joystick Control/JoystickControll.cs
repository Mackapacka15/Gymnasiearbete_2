using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickControll : MonoBehaviour
{

    public Joystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(joystick.Horizontal);
    }
}
