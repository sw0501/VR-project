using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerEvents : MonoBehaviour
{
    public UnityEvent onPlayerDead;
    public UnityEvent onPlayerAlive;
    public UnityEvent FullGauge;
    public Text Tutorial_intro;

    private void Dead()
    {
        onPlayerDead.Invoke();
    }

    private void Alive()
    {
        onPlayerAlive.Invoke();
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colide!!");
        //SceneManager.LoadScene(1);
        Dead();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit!!");
        Alive();
    }

    private void Update()
    {
        /*
        if(guage == 100)
        {
            FullGauge.Invoke();
            
        }
        */
    }

    public void SetunVisible()
    {
        Tutorial_intro.text = "You are Dead";
    }

    public void SetVisible()
    {
        Tutorial_intro.text = "You are Alive";
    }

}
