using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMsc1 : MonoBehaviour
{
    public static BackgroundMsc1 instance;

    void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}

