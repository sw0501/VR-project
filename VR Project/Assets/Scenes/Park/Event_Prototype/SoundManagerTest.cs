using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Background;
    public GameObject Effect;

    IEnumerator EffectSound()
    {
        //3초간 노래 재생
        Effect.SetActive(true);
        yield return new WaitForSeconds(3f);
        Effect.SetActive(false);
    }

    public void SetBackgroundOn()
    {
        Background.SetActive(true);
    }

    public void SetBackgroundOff()
    {
        Background.SetActive(false);
    }

    public void SetEffect()
    {
        StartCoroutine(EffectSound());
    }

}
