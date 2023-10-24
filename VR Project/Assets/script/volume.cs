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
    public XRController controller; // Oculus ��Ʈ�ѷ�

    public Sprite selectN;
    public Sprite selectY;


    public void ChangeVolume()
    {
        AdjustVolume(volumescound);
    }

    private void AdjustVolume(float amount)
    {
        // XR Origin(����)�� ����� �ҽ��� ã��
        var audioSource = FindObjectOfType<AudioSource>();

        if (audioSource != null)
        {
            // ���� ������ ������
            float currentVolume = audioSource.volume;
            Debug.Log(currentVolume);

            // ����� ���� ���� �����ϰ�, 0���� 1 ������ ������ ����
            currentVolume = Mathf.Clamp01(amount);

            // ������ ����
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
