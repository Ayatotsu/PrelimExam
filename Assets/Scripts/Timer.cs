using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    
    
    public float timeRemaining = 0;
    public bool timeIsRunning = true;
    public TMP_Text timeCounter;
    
    

    void Start()
    {
        timeIsRunning = true;
        
    }
    void Update()
    {
        if (timeIsRunning)
        {
            if (timeRemaining >= 0)
            {
                timeRemaining += Time.deltaTime;
                DisplayTime(timeRemaining);
            }
        }
    }

    public void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeCounter.text = string.Format("{0:00}:{1:00}", minutes, seconds);

    }
}
