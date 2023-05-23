using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImg;
    public Sprite soundOffImg;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;
    void Start()
    {
        soundOnImg = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImg;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImg;
            isOn = true;
            audioSource.mute = false;
        }
    }
}
