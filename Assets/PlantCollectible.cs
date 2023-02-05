using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantCollectible : MonoBehaviour
{
    public TextMeshProUGUI plantText;
    public bool isInTrigger = false;
    void OnTriggerEnter2D(Collider2D other)
   {
    // not working vvvv :/
        //plantText = GameObject.Find("PlantText");
        plantText.text = "Press H";
       Debug.Log("Object that entered the trigger : " + other);
        isInTrigger = true;
   }

   void OnTriggerExit2D(Collider2D other) {
    isInTrigger = false;
   }

   void Update() {
        if (isInTrigger && Input.GetKeyDown("h")) {
           Debug.Log("Harvesting...");
            gameObject.SetActive(false);
        }

   }
}
