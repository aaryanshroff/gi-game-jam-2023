using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneToLoad;
    public GameObject overlay;
    public GameObject grass;
    public GameObject overlaygray;
    public GameObject grassgray;
    public GameObject originalappletree;
    public GameObject originalorangetree;
    public GameObject goldenappletree;
    public GameObject goldenorangetree;
    public GameObject hourglass1;
    public GameObject hourglass2;
    private void Start(){
        overlay.SetActive(true);
        grass.SetActive(true);
        overlaygray.SetActive(false);
        grassgray.SetActive(false);
        originalappletree.SetActive(true);
        originalorangetree.SetActive(true);
        goldenappletree.SetActive(false);
        goldenorangetree.SetActive(false);
        hourglass1.SetActive(true);
        hourglass2.SetActive(true);
    }
    public void OnTriggerEnter2D(Collider2D other){
        Debug.Log("test");
        if(other.gameObject.name == "Player"){
            Debug.Log("test");
            //SceneManager.LoadScene(sceneToLoad);
            overlay.SetActive(false);
            grass.SetActive(false);
            overlaygray.SetActive(true);
            grassgray.SetActive(true);
            originalappletree.SetActive(false);
            originalorangetree.SetActive(false);
            goldenappletree.SetActive(true);
            goldenorangetree.SetActive(true);
            hourglass1.SetActive(false);
            hourglass2.SetActive(false);
        }
    }
}
