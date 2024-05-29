using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class v2Recolector : MonoBehaviour
{
    public int puntuacion = 0;
    public PuntuacionTotal puntuacionTotal;
    public TextMeshProUGUI puntuacionActualtext;
    public int puntuacionactual = 0;

    // Start is called before the first frame update
    void Start()
    {
        puntuacionTotal= GetComponent<PuntuacionTotal>();
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();  
            Debug.Log(pe.puntuacion);
            puntuacionTotal.sumar(collision.gameObject.GetComponent<MovimientoAutomatico>().puntuacion);
            Destroy(collision.gameObject);
            
        }
    }
}
