using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitsManager : MonoBehaviour
{
    public void AllFruitsCollected() {
        if (transform.childCount==1) {
            Debug.Log("All Fruits Collected. You Win!");
        }
    }
}
