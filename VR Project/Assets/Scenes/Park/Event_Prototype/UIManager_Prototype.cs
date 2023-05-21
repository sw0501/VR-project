using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager_Prototype : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text T;

    public void ChangeText(string text)
    {
        T.text = text;
    }
}
