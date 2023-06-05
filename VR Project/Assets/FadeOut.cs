using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    IEnumerator FadeCoroutine()
    {
        float fadeCount = 0;
        while (fadeCount < 1.0f)
        {
            fadeCount += 0.01f;
            yield return new WaitForSeconds(0.01f);
            this.GetComponent<Image>().color = new Color(0, 0, 0, fadeCount);

        }

        Destroy(GameObject.FindWithTag("Player"));
        SceneManager.LoadScene(1);
    }

    public void FadeOutFunc()
    {
        StartCoroutine(FadeCoroutine());
    }
}
