using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public CharacterController2D characterController;
    public Joystick joystick;
    public GameObject JoystickObject;

    public GameObject ButtonObject;

    public int playWay;

    float move = 0;

    bool jump = false;

    public float runSpeed;

    public void MoveLeft()
    {
        move = -1;
    }
    public void MoveRight()
    {
        move = 1;
    }
    public void StopMove()
    {
        move = 0;
    }
    public void Jump()
    {
        jump = true;
    }
    public void StopJump()
    {
        jump = false;
    }

    void Joystick()
    {
        if (playWay == 3)
        {
            move = joystick.Horizontal;
        }
    }

    void Accelerometer()
    {
        if (playWay == 1)
        {
            move = Input.acceleration.x;
        }
    }

    void Start()
    {
        playWay = PlayerPrefs.GetInt("activePlayWay");
        if (playWay == 3)
        {
            JoystickObject.SetActive(true);
        }
        else
        {
            JoystickObject.SetActive(false);
        }
        if (playWay == 2)
        {
            ButtonObject.SetActive(true);
        }
        else
        {
            ButtonObject.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        Joystick();
        Accelerometer();

        if (move > 1)
        {
            move = 1;
        }
        if (move < -1)
        {
            move = -1;
        }
        characterController.Move(move * runSpeed * Time.fixedDeltaTime, false, jump);
    }
    public int GetPlayWayController()
    {
        return playWay;
    }
}
