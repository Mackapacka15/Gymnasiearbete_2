using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScript : MonoBehaviour
{
    public movementScript playerMoveController;
    public Animator playerAnimator;
    public CharacterController2D playerController;
    public GameObject player;
    public TimerScript timer;
    public HighScores hs = new HighScores();
    public TextMeshProUGUI thisTime;
    public TextMeshProUGUI firstscore;
    public TextMeshProUGUI joystickHighScores;
    public TextMeshProUGUI buttonHighScores;
    public TextMeshProUGUI gyroHighScores;
    public GameObject endScene;
    bool isAcitve = false;

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (isAcitve == false)
        {
            playerMoveController.enabled = false;
            player.GetComponent<Rigidbody2D>().gravityScale = 0;
            playerAnimator.SetBool("Climb", true);
            isAcitve = true;
            Debug.Log("Starts Load");
            hs.LoadHighScores();
            Debug.Log("End Load");
            timer.StopTimerRecordTime();
            hs.AddScore(playerMoveController.playWay, timer.GetTimerRecordTime());
            UpdateScores();
        }
    }
    private void FixedUpdate()
    {
        if (isAcitve == true)
        {
            ActiveLoop();
        }
    }
    private void ActiveLoop()
    {
        playerController.Move(50 * Time.fixedDeltaTime, false, false);
        player.transform.position += new Vector3(0, 0.1f, 0);

    }
    public void FromEndSceneTrigger()
    {
        if (isAcitve == true)
        {
            isAcitve = false;
            playerMoveController.enabled = true;
            player.GetComponent<Rigidbody2D>().gravityScale = 3;
            playerAnimator.SetBool("Climb", false);
            endScene.SetActive(true);
        }
    }
    private void UpdateScores()
    {
        thisTime.text = timer.GetTimerRecordTime() + GetType(playerMoveController.playWay);
        firstscore.text = hs.firstScore + GetType(hs.firstMode);

        buttonHighScores.text = Scores(hs.buttonScores);
        joystickHighScores.text = Scores(hs.joystickScores);
        gyroHighScores.text = Scores(hs.gyroScores);
    }
    private string GetType(int type)
    {
        if (type == 1)
        {
            return "    Gyro";
        }
        if (type == 3)
        {
            return "    Joystick";
        }
        if (type == 2)
        {
            return "    Buttons";
        }

        return "Din't load";
    }
    private string Scores(List<float> list)
    {
        string scores = "";
        foreach (float item in list)
        {
            scores = scores + item + "<br>";
        }
        return scores;
    }
}