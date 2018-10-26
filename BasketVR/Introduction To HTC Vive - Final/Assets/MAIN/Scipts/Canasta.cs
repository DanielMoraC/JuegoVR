using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canasta : MonoBehaviour {

    public bool canasta1;
    public bool canasta2;
    public bool canasta3;
    public bool canasta4;
    public bool canasta5;

    //public int puntos = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bola" && canasta1)
        {
            Timer.canasta1hecha = true;
            Puntuación.puntostotales += 1f;
            //puntos = 2;
        }        

        if (other.gameObject.tag == "Bola" && canasta2)
        {
            Timer.canasta2hecha = true;
            Puntuación.puntostotales += 1.5f;
            //puntos = 3;
        }        

        if (other.gameObject.tag == "Bola" && canasta3)
        {
            Timer.canasta3hecha = true;
            Puntuación.puntostotales += 2.5f;
            //puntos = 5;
        }        

        if (other.gameObject.tag == "Bola" && canasta4)
        {
            Timer.canasta4hecha = true;
            Puntuación.puntostotales += 5f;
            //puntos = 10;
        }

        if (other.gameObject.tag == "Bola" && canasta5)
        {
            Timer.canasta4hecha = true;
            Puntuación.puntostotales += 10f;
            //puntos = 20;
        }

        /*
        if (other.gameObject.tag == "Bola" && canasta1 && Timer.canasta1hecha)
        {
            Puntuación.puntostotales += 2;            
            //puntos = 2;
        }else if (other.gameObject.tag == "Bola" && canasta1 && !Timer.canasta1hecha)
        {
            Timer.canasta1hecha = true;
            Puntuación.puntostotales += 2;
            //puntos = 2;
        }

        if (other.gameObject.tag == "Bola" && canasta2 && Timer.canasta2hecha)
        {
            Puntuación.puntostotales += 3;
            //puntos = 3;
        }else if (other.gameObject.tag == "Bola" && canasta2 && !Timer.canasta2hecha)
        {
            Timer.canasta2hecha = true;
            Puntuación.puntostotales += 3;
            //puntos = 3;
        }

        if (other.gameObject.tag == "Bola" && canasta3 && Timer.canasta3hecha)
        {
            Puntuación.puntostotales += 5;
            //puntos = 5;
        }else if (other.gameObject.tag == "Bola" && canasta3 && !Timer.canasta3hecha)
        {
            Timer.canasta3hecha = true;
            Puntuación.puntostotales += 5;
            //puntos = 5;
        }

        if (other.gameObject.tag == "Bola" && canasta4 && Timer.canasta4hecha)
        {
            Puntuación.puntostotales += 10;
            //puntos = 10;
        }else if (other.gameObject.tag == "Bola" && canasta4 && !Timer.canasta4hecha)
        {
            Timer.canasta4hecha = true;
            Puntuación.puntostotales += 10;
            //puntos = 10;
        }*/
    }
}
