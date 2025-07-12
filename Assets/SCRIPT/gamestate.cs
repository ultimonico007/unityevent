using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class state : MonoBehaviour
{
    public UnityEvent onGameStart;
    public UnityEvent onGamePause;

    private bool juegoEnMarcha = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            juegoEnMarcha = !juegoEnMarcha;


            if (juegoEnMarcha)
            {
                onGameStart.Invoke();
                Time.timeScale = 1f;
            }
            else
            {
                onGamePause.Invoke();
                Time.timeScale = 0f;
            }
        }
    }
}

