using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlantCollectible : MonoBehaviour
{
    public GameObject plantText;
    void OnTriggerEnter2D(Collider2D other)
   {
        plantText = GameObject.Find("PlantText");
        plantText.GetComponent<Text>().text = "Press H";
       Debug.Log("Object that entered the trigger : " + other);
   }
}
