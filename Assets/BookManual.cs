using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManual : MonoBehaviour
{
    public GameObject bookInstructions;
    // Start is called before the first frame update
    void Start()
    {
     bookInstructions.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
         {
             Debug.Log("Click");
             bookInstructions.SetActive(true);
         }
        if(Input.GetKeyDown(KeyCode.Escape)){
            bookInstructions.SetActive(false);
        }
    }
}
