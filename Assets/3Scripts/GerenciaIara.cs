using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaIara : GerenciaGrid
{
    public GameObject tileYARA;
    public TextMeshProUGUI yaraGoal1Text;
    public TextMeshProUGUI pointsText;
    public int newpontuacaoMax = 500;
    void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("fase1yara"))
        {
            if (int.Parse(pointsText.text) >= newpontuacaoMax)
                SceneManager.LoadScene(18);
        }
    }

}
       