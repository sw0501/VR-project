using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text playerStateText;
    public void onPlayerDead()
    {
        Debug.Log("Dead Event!!!");
        playerStateText.text = "You Die!!!";
    }

    public void onPlayerAlive()
    {
        Debug.Log("Alive Event!!!");
        playerStateText.text = "You Alive!!!";
    }

    private void Start()
    {
        playerStateText.text = "You Alive!!!";
    }
}
