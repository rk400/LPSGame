using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class FruitsManager : MonoBehaviour
{
    public GameObject winLevel;
    public GameObject transition;
    public TMP_Text collectedFruits;
    public TMP_Text totalFruits;
    private int totalFruitsInLevel;

    public void Start() {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update(){
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        collectedFruits.text = transform.childCount.ToString();
    }
    
    public void AllFruitsCollected() {
        if (winLevel == null) {
            
        }
        if (transform.childCount == 0) {
            Debug.Log("All Fruits Collected. You Win!");
            transition.SetActive(true);
            Invoke("ChangeScene", 1);
            
        }
    }

    public void ChangeScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
