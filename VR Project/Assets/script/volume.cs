using System;
using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class volume : MonoBehaviour
{
    // Start is called before the first frame update

    public float volumescound;
    public XRController controller; // Oculus 컨트롤러

    public Sprite selectN;
    public Sprite selectY;


    public void ChangeVolume()
    {
        AdjustVolume(volumescound);
    }

    private void AdjustVolume(float amount)
    {
        // XR Origin(방향)의 오디오 소스를 찾음
        var audioSource = FindObjectOfType<AudioSource>();

        if (audioSource != null)
        {
            // 현재 볼륨을 가져옴
            float currentVolume = audioSource.volume;
            Debug.Log(currentVolume);

            // 변경된 볼륨 값을 적용하고, 0에서 1 사이의 범위로 유지
            currentVolume = Mathf.Clamp01(amount);

            // 볼륨을 설정
            audioSource.volume = currentVolume;
        }
        else
        {
            Debug.Log("Error");
        }
    }

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
