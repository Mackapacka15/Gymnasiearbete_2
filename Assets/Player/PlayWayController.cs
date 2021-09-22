using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayWayController : MonoBehaviour
{
    public GameObject ButtonController;
        public GameObject buttonLeft;
        public GameObject buttonRight;
    public GameObject JoystickController;
        public GameObject Joystick;
    public GameObject GyroController;
    private void Start() 
    {
        int active = PlayerPrefs.GetInt("activePlayWay");
        if(active == 1)
        {
            activateGyro();
        }
        else if(active == 2)
        {
            activateButtons();
        }
        else if(active == 3)
        {
            activateJoystick();
        }
        else
        {
            Application.Quit();
        }
        Debug.Log(active);
    }
    void activateButtons()
    {
        ButtonController.SetActive(true);
        buttonLeft.SetActive(true);
        buttonRight.SetActive(true);
        JoystickController.SetActive(false);
        Joystick.SetActive(false);
        GyroController.SetActive(false);
    }
    void activateGyro()
    {
        ButtonController.SetActive(false);
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
        JoystickController.SetActive(false);
        Joystick.SetActive(false);
        GyroController.SetActive(true);
    }
    void activateJoystick()
    {
        ButtonController.SetActive(false);
        buttonLeft.SetActive(false);
        buttonRight.SetActive(false);
        JoystickController.SetActive(true);
        Joystick.SetActive(true);
        GyroController.SetActive(false);
    }
}
