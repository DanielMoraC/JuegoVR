﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puntuación : MonoBehaviour {

    static public float puntostotales;

    public Text Puntos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Puntos.text = "Current Points: " + puntostotales;
    }
}
