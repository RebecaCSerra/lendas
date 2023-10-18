using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSound : MonoBehaviour
{
    private Sprite soundOnImg1;
    public Sprite soundOffImg1;
    private Sprite soundOnImg2;
    public Sprite soundOffImg2;
    public Button button;
    private bool isOn = true;

    public AudioSource fasecandycrush;
    void Start()
    {
        soundOnImg1 = button.image.sprite;
        soundOnImg2 = button.image.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        if (isOn)
        {
            button.image.sprite = soundOffImg1;
            button.image.sprite = soundOffImg2;
            isOn = false;
           fasecandycrush.mute = true;
        }
        else
        {
            button.image.sprite = soundOnImg1;
            button.image.sprite = soundOnImg2;
            isOn = true;
           fasecandycrush.mute = false;
        }
    }


}
