using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Timer : MonoBehaviour
{
    //video followed: https://www.youtube.com/watch?v=POq1i8FyRyQ&ab_channel=RehopeGames
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingTime;

    // Update is called once per frame
    void Update()
    {   //prevents timer going into -numbers
        if(remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else if(remainingTime < 0)
        {
            remainingTime = 0;
        }
        //remaining time maths for better format (min & secs)
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = String.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
