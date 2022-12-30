using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour
{
    void Start(){}
    void Update(){}
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}
