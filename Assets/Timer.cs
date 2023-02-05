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
    public GameObject seed;
    public GameObject tree;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
        hourglass.SetActive(true);
        seed.SetActive(true);
        tree.SetActive(false);
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
                seed.SetActive(false);
                tree.SetActive(true);
            }
        }
    }

}