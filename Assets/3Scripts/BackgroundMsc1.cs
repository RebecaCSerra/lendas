using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMsc1 : MonoBehaviour
{
        public static BackgroundMsc1 _instance;

        void Awake()
        {
        print("instance"+ _instance);
        if (!_instance)
            _instance = this;
        
        else
        {
            Destroy(this.gameObject);
            print("destruiu");
        }
            


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
            if (SceneManager.GetActiveScene().name == "1inicioy")
            {
                GetComponent<AudioSource>().Stop();
            }

        }
    }



