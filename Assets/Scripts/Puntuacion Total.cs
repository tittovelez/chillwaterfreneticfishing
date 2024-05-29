using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // Necesario para trabajar con escenas
using UnityEngine.UI;

public class PuntuacionTotal : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;
    public int puntuacionParaGanar = 20; // Establece el umbral de puntuaci�n para ganar
    public string Victoria; // Nombre de la escena de victoria
    public int puntuacionactual = 0;
    private int puntuacionTotal = 10;
    private int puntuacion = 0;
    public TextMeshProUGUI puntuacionActualtext;
    public int lvlc = 1;
    // M�todo para actualizar el texto de la puntuaci�n
    public void sumar(int puntos)
    {
       puntuacionactual = puntos + puntuacionactual;
    }
    void ActualizarTextoPuntuacion()
    {
        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = puntuacionTotal.ToString();
            
        }
    }

    // M�todo para sumar la puntuaci�n
    public void SumarPuntuacion(int puntuacion)
    {
        puntuacionTotal += puntuacion;
        ActualizarTextoPuntuacion();

        // Verificar si la puntuaci�n total alcanza el umbral para ganar
        if (puntuacionTotal >= puntuacionParaGanar)
        {
            Ganar();
        }
    }

    // M�todo para cargar la escena de victoria
    void Ganar()
    {
        // Cargar la escena de victoria
        if (!string.IsNullOrEmpty(Victoria))
        {
            SceneManager.LoadScene(Victoria);
        }
        else
        {
            Debug.LogWarning("Victoria.");
        }
    }
    private void Update()
    {
        puntuacionActualtext.text = puntuacionactual.ToString();
        if (puntuacionactual >= 300)
        {
            SceneManager.LoadScene("Victoria");
        }

    }
}
