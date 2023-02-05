using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("test");
        if(other.gameObject.name == "Player"){
            Debug.Log("test");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
