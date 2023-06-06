using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatureBGM : MonoBehaviour
{

    public AudioManager audioManager;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        audioManager.PlayBGM("BGM1");
        audioManager.PlaySFX("Wind");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
