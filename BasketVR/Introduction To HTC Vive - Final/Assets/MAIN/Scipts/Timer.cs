using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    float timeLeft = 20;

    public Text tiempo;

    private bool contando = true;

    public GameObject canasta;

    static public bool canasta1hecha = false;
    static public bool canasta2hecha = false;
    static public bool canasta3hecha = false;
    static public bool canasta4hecha = false;
    static public bool canasta5hecha = false;

    //public bool funciona = false;

    static public bool Todas = false;

    void Update()
    {        
        tiempo.text = "Seconds remaining: " + Mathf.Round(timeLeft);

        if (canasta1hecha && canasta2hecha && canasta3hecha && canasta4hecha)
        {
            //funciona = true;
            Todas = true;
        }

        if (contando)
        {
            timeLeft -= Time.deltaTime;
        }

        if (timeLeft <= 0)
        {
            print("Fin");           
        }

        if (timeLeft <= 0 && Todas)
        {
            canasta.SetActive(true);
        }
    }

    public void PlayGame()
    {
           
    }
}
