using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerTest : MonoBehaviour
{
    public int health = 0;
    public UnityEvent Damage;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(health);
    }

    private void OnTriggerEnter(Collider other)
    {
        Damage.Invoke();
    }

    public void player_damaged()
    {
        health--;
        Debug.Log("damaged");
        Debug.Log(health);
    }
}
