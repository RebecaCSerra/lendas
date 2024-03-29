using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public float TimeValue = 90;
    public Text timeText;
    public static bool Running = true;

    void Start()
    {

    }
    void Update()
    {
        if (TimeValue > 0)
        {
            if(Running)
            TimeValue -= Time.deltaTime;
        }
        else
        {
            TimeValue = 0;
            SceneManager.LoadScene(17);
        }

        DisplayTime(TimeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }

    

}
