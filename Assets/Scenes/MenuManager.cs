using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void newScene(int wayToPlay)//0 for Gyro, 1 for Joystick, 2 for Buttons
    {
        PlayerPrefs.SetInt("activePlayWay", wayToPlay);
        Manager.Load(Manager.Scene.Lobby);
    }
}
