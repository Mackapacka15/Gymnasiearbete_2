using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Manager
{
    public enum Scene
    {
        Menu,
        Lobby,
        Main_Map,
        Gyro,
    }
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }   
}