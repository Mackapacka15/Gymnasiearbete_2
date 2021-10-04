using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GetScores
{
    public bool first;
    public float firstScore;
    public int firstMode;
    public float[] joystickScores;
    public float[] buttonScores;
    public float[] gyroScores;

    public GetScores(End_Scene e)
    {
        first = e.first;
        firstScore = e.firstScore;
        firstMode = e.firstMode;

        joystickScores = e.joysticScores.ToArray();
        buttonScores = e.buttonScores.ToArray();
        gyroScores = e.gyroScores.ToArray();
    }
}
