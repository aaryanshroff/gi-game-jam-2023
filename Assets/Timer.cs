using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float timeRemaining = 10f;
    public bool timerIsRunning = false;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0f)
            {
                timeRemaining -= Time.deltaTime;
                countdownText.text = timeRemaining.ToString();
            }
            else
            {
                countdownText.text = timeRemaining.ToString();
                Debug.Log("Time has run out!");
                timeRemaining = 0f;
                timerIsRunning = false;
            }
        }
    }

}