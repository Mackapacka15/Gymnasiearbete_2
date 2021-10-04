using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Player.cs
public class HighScores
{
    public bool first;
    public float firstScore;
    public int firstMode;
    public List<float> joystickScores;
    public List<float> buttonScores;
    public List<float> gyroScores;

    public void SaveHighScores()
    {
        SaveScores.SaveData(this);
    }

    public void LoadHighScores()
    {
        HighScores data = SaveScores.LoadScores();
        first = data.first;
        firstScore = data.firstScore;
        firstMode = data.firstMode;
        joystickScores = data.joystickScores;
        buttonScores = data.buttonScores;
        gyroScores = data.gyroScores;
    }
}

