using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.Mathematics;


public class Timer : MonoBehaviour
{
    public TextMeshProUGUI countdownText;
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public GameObject hourglass;
    public GameObject appleseeds;
    public GameObject appletree;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        hourglass.SetActive(true);
        appleseeds.SetActive(true);
        appletree.SetActive(false);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= (Time.deltaTime);
                countdownText.text = (Mathf.Round(timeRemaining)).ToString();
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                hourglass.SetActive(false);
                appleseeds.SetActive(false);
                appletree.SetActive(true);
            }
        }
    }

}