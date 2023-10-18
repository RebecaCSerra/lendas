using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorialboimusic : MonoBehaviour
{
    private static tutorialboimusic _instance;

    void Awake()
    {

        if (!_instance)
            _instance = this;
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
        if (SceneManager.GetActiveScene().name == "1inicioy")
        {
            GetComponent<AudioSource>().Stop();
        }
        if (SceneManager.GetActiveScene().name == "fase1yara")
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}