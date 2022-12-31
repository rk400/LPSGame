using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    public GameObject transition;

    void Start(){}
    void Update(){}
    public void Exit()
    {
        transition.SetActive(true);
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
