using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Player.cs
public class HighScores
{
    public bool first = true;
    public float firstScore;
    public int firstMode;
    public List<float> joystickScores = new List<float>();
    public List<float> buttonScores = new List<float>();
    public List<float> gyroScores = new List<float>();

    public void SaveHighScores()
    {
        SaveScores.SaveData(this);
    }

    public void LoadHighScores()
    {
        GetScores data = SaveScores.LoadScores();
        Debug.Log($"Data isn't null: {!(data == null)}");
        if (data == null)
        {
            first = true;
            firstScore = 100f;
            firstMode = 0;
            joystickScores = AddRandomScores(joystickScores);
            buttonScores = AddRandomScores(buttonScores);
            gyroScores = AddRandomScores(gyroScores);
            Debug.Log("Data Generated");
            Debug.Log("Button Generated:");
            foreach (var item in buttonScores)
            {
                Debug.Log(item);
            }
        }
        else
        {
            Debug.Log("Button Highscores:");
            foreach (var item in buttonScores)
            {
                Debug.Log(item);
            }
            first = data.first;
            Debug.Log($"Loading: {first}");
            firstScore = data.firstScore;
            firstMode = data.firstMode;
            joystickScores = ConvertScores(data.joystickScores);
            buttonScores = ConvertScores(data.buttonScores);
            gyroScores = ConvertScores(data.gyroScores);
        }
    }
    public void AddScore(int type, float score)
    {
        Debug.Log("Adding Scores");
        if (first == true)
        {
            first = false;
            firstScore = score;
            firstMode = type;
            Debug.Log("FirstTime");
        }

        if (type == 0)
        {
            gyroScores.Add(score);
            gyroScores.Sort();
            if (gyroScores.Count >= 4)
            {
                gyroScores.RemoveAt(3);
            }
        }
        else if (type == 1)
        {
            joystickScores.Add(score);
            joystickScores.Sort();
            if (joystickScores.Count >= 4)
            {
                joystickScores.RemoveAt(3);
            }
        }
        else if (type == 2)
        {
            buttonScores.Add(score);
            buttonScores.Sort();
            if (buttonScores.Count >= 4)
            {
                buttonScores.RemoveAt(3);
            }
        }
        SaveHighScores();
    }
    private List<float> AddRandomScores(List<float> list)
    {
        list.Add(30f);
        list.Add(40f);
        list.Add(50f);

        return list;
    }
    private List<float> ConvertScores(float[] scores)
    {
        List<float> listScores = new List<float>();
        foreach (float item in scores)
        {
            listScores.Add(item);
        }
        return listScores;
    }
}

