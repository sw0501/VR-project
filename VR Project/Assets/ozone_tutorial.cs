using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ozone_tutorial : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Ozone_Prefab;

    private void Awake()
    {
        
    }

    void Start()
    {
        GameObject Ozone = Instantiate(Ozone_Prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
