using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveScores
{
    public static void SaveData()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.fbx";
        FileStream stream = new FileStream(path, FileMode.Create);

        GetScores scores = new GetScores();

        formatter.Serialize(stream, scores);
        stream.Close();

    }
    public static GetScores LoadScores()
    {
        string path = Application.persistentDataPath + "/player.fbx";
        if (File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            GetScores scores = formatter.Deserialize(stream) as GetScores;
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
