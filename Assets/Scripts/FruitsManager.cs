using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FruitsManager : MonoBehaviour
{
    public GameObject winLevel;

    private void Update(){
        AllFruitsCollected();
    }
    
    public void AllFruitsCollected() {
        if (transform.childCount == 0) {
            Debug.Log("All Fruits Collected. You Win!");
            winLevel.SetActive(true);
            Invoke("ChangeScene", 1);
            
        }
    }

    public void ChangeScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
