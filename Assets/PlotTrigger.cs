using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlotTrigger : MonoBehaviour
{
    public TextMeshProUGUI plantText;
    public bool isInTrigger = false;
    public GameObject timer;
    public GameObject hourglass;
    public GameObject seed;
    public GameObject tree;

    void OnTriggerEnter2D(Collider2D other) {
        plantText.text = "Press S";
        isInTrigger = true;
    }

    void OnTriggerExit2D(Collider2D other) {
    plantText.text = "";
    isInTrigger = false;
   }

    void Update() {
        if (isInTrigger && Input.GetKeyDown("s")) {
           Debug.Log($"Planting...");
            timer.GetComponent<Timer>().timerIsRunning = true;
            hourglass.SetActive(true);
            seed.SetActive(true);
            tree.SetActive(false); 
        }

   }
}
