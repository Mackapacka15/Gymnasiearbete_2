using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

//SaveSystem
public static class SaveScores
{
    public static void SaveData(HighScores highScores)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fbx";
        FileStream stream = new FileStream(path, FileMode.Create);

        GetScores data = new GetScores(highScores);
        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("Save Succesfull");
        Debug.Log("Button Saved:");
        foreach (var item in data.buttonScores)
        {
            Debug.Log(item);
        }
        Debug.Log("Joystick Saved:");
        foreach (var item in data.joystickScores)
        {
            Debug.Log(item);
        }
        Debug.Log("Gyro Saved:");
        foreach (var item in data.gyroScores)
        {
            Debug.Log(item);
        }
    }
    public static GetScores LoadScores()
    {
        string path = Application.persistentDataPath + "/player.fbx";
        Debug.Log("Loading");
        if (File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            GetScores scores = formatter.Deserialize(stream) as GetScores;
            stream.Close();
            Debug.Log("Load Succesfull");
            return scores;
        }
        else
        {
            UnityEngine.Debug.LogError("Save file not found in " + path);
            return null;
        }
    }


}
