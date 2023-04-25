using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerEvents : MonoBehaviour
{
    public UnityEvent onPlayerDead;
    public UnityEvent onPlayerAlive;

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
        SceneManager.LoadScene(1);
        Dead();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit!!");
        Alive();
    }

}
