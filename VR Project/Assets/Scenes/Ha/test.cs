using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    [SerializeField]
    private AudioManager Audio;

    // Start is called before the first frame update
    void Start()
    {
        Audio.PlayBGM("BGM0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
