using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Scene
{
    public bool first;
    public float firstScore;
    public int firstMode;
    public List<float> joysticScores = new List<float>();
    public List<float> buttonScores = new List<float>();
    public List<float> gyroScores = new List<float>();
    float run;
    int control;
    public void RunOver()
    {
        GetScores data = SaveScores.LoadScores();
        run = 0.10f;
        control = 1;
        first = data.first;
        firstScore = data.firstScore;
        firstMode = data.firstMode;

        foreach (var item in data.gyroScores)
        {
            gyroScores.Add(item);
        }
        foreach (var item in data.buttonScores)
        {
            buttonScores.Add(item);
        }
        foreach (var item in data.joystickScores)
        {
            joysticScores.Add(item);
        }
        if (control == 1)
        {
            gyroScores.Add(run);
        }
        else if (control == 2)
        {
            buttonScores.Add(run);
        }
        else if (control == 3)
        {
            joysticScores.Add(run);
        }



    }
}
