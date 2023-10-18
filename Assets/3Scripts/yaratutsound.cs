using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yaratutsound : MonoBehaviour
{
    private static yaratutsound _instance;

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
            Destroy(this.gameObject);
        }
    }
}