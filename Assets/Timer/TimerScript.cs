using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public GameObject player;

    public TextMeshProUGUI timerText;

    float timerRecordValue;
    float timerCountDownValue;

    bool timerCountDownActive = false;
    bool timerRecordActive = false;

    public GameObject lobbyMap;
    public GameObject mainMap;

    private void Start()
    {
        StartTimerCountDownTime(10.0f);
    }

    private void Update()
    {
        if (timerCountDownActive == true)
        {
            timerCountDownValue -= Time.deltaTime;
            UpdateCountDownTimer();
            if (timerCountDownValue <= 0)
            {
                StopTimerCountDownTime();
            }
        }

        if (timerRecordActive == true)
        {
            timerRecordValue += Time.deltaTime;
            UpdateRecordTimer();
        }
    }

    public void StartTimerRecordTime()
    {
        timerRecordActive = true;
    }
    public void StopTimerRecordTime()
    {
        timerRecordActive = false;
    }

    public float GetTimerRecordTime()
    {
        return timerRecordValue;
    }
    void UpdateRecordTimer()
    {
        timerText.text = (Mathf.Round(timerRecordValue * 100) / 100).ToString();
    }

    public void StartTimerCountDownTime(float time)
    {
        timerCountDownActive = true;
        timerCountDownValue = time;
    }
    void StopTimerCountDownTime()   //Starts the main lobby
    {
        player.transform.position = new Vector3();
        timerCountDownActive = false;
        lobbyMap.SetActive(false);
        mainMap.SetActive(true);
        StartTimerRecordTime();
    }
    void UpdateCountDownTimer()
    {
        timerText.text = (Mathf.Round(timerCountDownValue * 100) / 100).ToString();
    }
}
