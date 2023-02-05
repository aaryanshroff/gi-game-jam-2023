using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantCollectible : MonoBehaviour
{
    public TextMeshProUGUI plantText;
    public TextMeshProUGUI healthText;
    public GameObject healthBar;
    public bool isInTrigger = false;
    public int health = 0;
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
           Debug.Log($"Harvesting... you got {health} health");
            gameObject.SetActive(false);
            string[] words = healthText.text.Split(' ');
            healthText.text = $"Health: {int.Parse(words[1]) + health}";
            healthBar.GetComponent<HealthBar>().SetHealth(int.Parse(words[1]) + health);
        }

   }
}
