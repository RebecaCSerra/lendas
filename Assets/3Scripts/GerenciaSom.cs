using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GerenciaSom : MonoBehaviour
{
    private Sprite volume;
    public Sprite mudo;
    public Button button;
    private bool isOn = true;

    public AudioSource audioSource;
    void Start()
    {
        volume = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = mudo;
            isOn = false;
            audioSource.mute = true;
        }
        else
        {
            button.image.sprite = volume;
            isOn = true;
            audioSource.mute = false;
        }
    }

}
