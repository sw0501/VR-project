using MonsterLove.StateMachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonsterLove.StateMachine;
using UnityEngine.Events;
using Unity.EditorCoroutines;

public class FSM_Prototype : MonoBehaviour
{

    public GameObject GameManager;

    public UnityEvent Init_Start;
    public UnityEvent Init_End;
    public UnityEvent Prepare;
    public UnityEvent Grab_Sword;
    public UnityEvent Tutorial_Start;
    public UnityEvent Start_Start;

    public enum States
    {
        Init,
        Tutorial,
        Start,
        End
    }

    IEnumerator Create_Sword()
    {
        yield return new WaitForSeconds(3f);
        //오존 생성 및 검 합쳐지는 이펙트 
        //검 생성 사운드
        //컨트롤러 진동 연결
        Prepare.Invoke();
    }

    StateMachine<States> fsm;

    private void Awake()
    {
        fsm = StateMachine<States>.Initialize(this);

        fsm.ChangeState(States.Init);
        
    }

    private void Init_Enter()
    {
        Debug.Log("Init");
        //컨트롤러 빨간 빛 매핑 
        Init_Start.Invoke();
        StartCoroutine(Create_Sword());
        Init_End.Invoke();
    }

    private void Init_Update()
    {
        //사용자가 검과 상호작용한 경우
        if (GameManager.GetComponent<GameManager>().isGrabSword == true)
        {
            //연결되어야 하는 함수
            //컨트롤러 1초간 진동
            //검에 붉은 빛 이펙트
            //컨트롤러에 검 매핑
            Grab_Sword.Invoke();
            fsm.ChangeState(States.Tutorial);
        }
    }

    private void Tutorial_Enter()
    {
        //오존 생성
        //오존 파괴하라는 자막 제공
        Tutorial_Start.Invoke();
    }

    private void Tutorial_Update() 
    {
        //첫 오존이 파괴될 경우
        if (GameManager.GetComponent<GameManager>().isOzoneBroke == true)
        {
            fsm.ChangeState(States.Start);
        }
    }

    private void Start_Enter()
    {
        //오존 파괴 게이지 UI 제공
        //필요할 시 오존 생성하는 컴포넌트 활성화 시킬 수 있음 (coroutin 활용하여 생성 주기 만들기 가능)
        Start_Start.Invoke();
    }

    private void Start_Update()
    {
        //게이지가 다 채워졌다면
        if (GameManager.GetComponent<GameManager>().ifFullGauge == true)
        {
            fsm.ChangeState(States.End);
        }
    }
}
