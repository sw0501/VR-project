using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterLove.StateMachine;
using UnityEngine.Events;

public class FSM_TEST : MonoBehaviour
{
    enum States{
        Init,
        Start,
        End
    }

    public UnityEvent<string> ChangeText;
    public UnityEvent GameStart;
    public UnityEvent GameEnd;
    public GameObject GM;

    IEnumerator InitToStart(float wait_time)
    {
        Debug.Log("wait");
        yield return new WaitForSeconds(wait_time);
        Debug.Log("job");
        fsm.ChangeState(States.Start);
    }

    IEnumerator GameExit()
    {
        ChangeText.Invoke("After 3s Game Exit");
        yield return new WaitForSeconds(3f);
        
        Application.Quit();
    }

    StateMachine<States> fsm;

    private void Awake()
    {
        fsm = StateMachine<States>.Initialize(this);

        fsm.ChangeState(States.Init);
    }

    private void Init_Enter()
    {
        ChangeText.Invoke("Init");
        Debug.Log("Init");
        //3초간 대기한 후에 게임 시작
        StartCoroutine(InitToStart(3f));
    }

    private void Start_Enter()
    {
        Debug.Log("Start");
        
        ChangeText.Invoke("Start");
        GameStart.Invoke();
    }

    private void Start_Update()
    {
        if(GM.GetComponent<GameManagerTest_Prototype>().isEnd == true) 
        {
            fsm.ChangeState(States.End);
        }
    }

    private void End_Enter()
    {
        ChangeText.Invoke("End");
        GameEnd.Invoke();

    }
}
