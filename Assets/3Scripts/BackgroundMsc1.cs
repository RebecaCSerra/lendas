using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMsc1 : MonoBehaviour    
    {
        private static BackgroundMsc1 _instance;

        void Awake()
        {
            //if we don't have an [_instance] set yet
            if (!_instance)
                _instance = this;
            //otherwise, if we do, kill this thing
            else
                Destroy(this.gameObject);


            DontDestroyOnLoad(this.gameObject);
        }
      void Update()
    {
        if (SceneManager.GetActiveScene().name == "fase1boi")
        {
            GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "1inicio")
        {
            GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "2comb")
        {
            GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "3moves")
        {
            GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "4points")
        {
            GetComponent<AudioSource>().Pause();
        }
        if (SceneManager.GetActiveScene().name == "5jogue")
        {
            GetComponent<AudioSource>().Pause();
        }

    }
    }


