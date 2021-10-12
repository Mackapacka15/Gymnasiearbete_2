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

    }
    public static HighScores LoadScores()
    {
        string path = Application.persistentDataPath + "/player.fbx";
        if (File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            HighScores scores = formatter.Deserialize(stream) as HighScores;
            stream.Close();
            return scores;

        }
        else
        {
            UnityEngine.Debug.LogError("Save file not found in " + path);
            return null;
        }
    }


}
