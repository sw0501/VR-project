using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class usehand : MonoBehaviour
{
    public Sprite selectN;
    public Sprite selectY;


    // Start is called before the first frame update
    public void ChangeImage(bool tf)
    {
        if (tf)
        {
            this.GetComponent<Image>().sprite = selectY;
        }
        else
        {
            this.GetComponent<Image>().sprite = selectN;
        }

    }
}
