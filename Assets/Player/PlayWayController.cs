using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWayController : MonoBehaviour
{
    public GameObject buttonLeft;
    public GameObject buttonRight;
    public GameObject Joystick;
    public GameObject GyroController;
    void activateButtons()
    {
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
        Joystick.SetActive(false);
        GyroController.SetActive(false);
    }
    void activateGyro()
    {
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
        Joystick.SetActive(true);
        GyroController.SetActive(false);
    }
    void activateJoystick()
    {
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
        Joystick.SetActive(false);
        GyroController.SetActive(true);
    }
}