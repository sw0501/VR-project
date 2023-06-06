using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class passScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SceneManager.LoadScene(3);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(4);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene(5);
        }
    }
}
