//PlayerData

[System.Serializable]
public class GetScores
{
    public bool first;
    public float firstScore;
    public int firstMode;
    public float[] joystickScores;
    public float[] buttonScores;
    public float[] gyroScores;

    public GetScores(HighScores e)
    {
        first = e.first;
        firstScore = e.firstScore;
        firstMode = e.firstMode;

        joystickScores = e.joystickScores.ToArray();
        buttonScores = e.buttonScores.ToArray();
        gyroScores = e.gyroScores.ToArray();
    }
}
