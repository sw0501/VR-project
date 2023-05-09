using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using MonsterLove.StateMachine; //1. Remember the using statement
using Unity.VisualScripting;

public class FSM : MonoBehaviour
{
    /*
    public GameObject player;

    public enum States
    {
        Init,
        Play,
        Win,
        Lose
    }

    StateMachine<States> fsm;

    private void Awake()
    {
        fsm = StateMachine<States>.Initialize(this);

        fsm.ChangeState(States.Init);
        fsm.ChangeState(States.Play);
    }

    private void Init_Enter()
    {
        Debug.Log("Ready");
    }

    private void Play_Enter()
    {
        Debug.Log("Spawning Player");
    }

    private void Play_FixedUpdate()
    {
        Debug.Log("Doing Physics stuff");
    }
    private void Play_Update()
    {

        Debug.Log(player.GetComponent<PlayerTest>().health);

        if (player.GetComponent<PlayerTest>().health <= 0)
        {
            fsm.ChangeState(States.Lose); //3. Easily trigger state transitions
        }
        
    }
    void Play_Exit()
    {
        Debug.Log("Despawning Player");
    }

    void Win_Enter()
    {
        Debug.Log("Game Over - you won!");
    }

    void Lose_Enter()
    {
        Debug.Log("Game Over - you lost!");

    }
    */
}
