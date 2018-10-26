using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    float timeLeft = 90;

    public Text tiempo;

    private bool contando = false;

    void Update()
    {        
        tiempo.text = "Seconds remaining: " + Mathf.Round(timeLeft);

        if (contando)
        {
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft <= 0)
        {
            print("Fin");
        }
    }

    public void PlayGame()
    {
           
    }
}
