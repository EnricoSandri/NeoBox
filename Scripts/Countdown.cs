using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{

    public int CountDownStartValue;
    public Text timer;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    private void countDownTimer()
    {
        if (CountDownStartValue > 0)
        {
            CountDownStartValue--;
            TimeSpan timeSpan = TimeSpan.FromSeconds(CountDownStartValue);
            timer.text = "TIMER " + timeSpan.Minutes + " : " + timeSpan.Seconds;
            Invoke("countDownTimer", 1.0f);
        }
    }
}
