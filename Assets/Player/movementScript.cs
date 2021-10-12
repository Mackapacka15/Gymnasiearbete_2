using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class movementScript : MonoBehaviour
{
    public CharacterController2D characterController;
    public Joystick joystick;
    public GameObject JoystickObject;

    public TextMeshProUGUI theText;

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
            move = Input.acceleration.x * 2;
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

<<<<<<< HEAD
        move = Mathf.Clamp(move, -1, 1);
=======
        if (move > 1)
        {
            move = 1;
        }
        if (move < -1)
        {
            move = -1;
        }
>>>>>>> 33c09f301d53137eb7e911ac4adfac4633735e39
        characterController.Move(move * runSpeed * Time.fixedDeltaTime, false, jump);
        theText.text = move.ToString();
    }
    public int GetPlayWayController()
    {
        return playWay;
    }
}
