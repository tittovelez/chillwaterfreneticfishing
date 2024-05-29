using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PeAnzuelo : MonoBehaviour
{
    private PuntuacionTotal puntuacionTotalScript;
    private int puntuacion;
    private Transform objetoRecoger; // Referencia al objeto con el tag "Recoger"

    void Start()
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Anzuelo"))
        {
            // Guarda la referencia al objeto con el tag "Recoger"
            objetoRecoger = collision.gameObject.transform;
        }
        if (collision.gameObject.CompareTag("ObjectController"))
        {
            if (puntuacionTotalScript != null)
            {
                // Llama al m�todo SumarPuntuacion() del objeto PuntuacionTotal y pasa su propia puntuaci�n
                puntuacionTotalScript.SumarPuntuacion(puntuacion);
            }
        }
    }

    void Update()
    {
        // Verifica si tenemos la referencia al objeto con el tag "Recoger"
        if (objetoRecoger != null)
        {
            // Actualiza la posici�n del objeto al que est� adjunto
            transform.position = objetoRecoger.position;
        }
    }
}

