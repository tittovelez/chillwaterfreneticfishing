using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class Anzuelo : MonoBehaviour
{
    public TextMeshProUGUI puntuacionActualtext;
    public int lvlc = 1;
    private bool isCKeyDisabled = false;
    public int nivelpez;
    public PuntuacionTotal p;
    private void Start()
    {
        
    }
    void Update()
    {
         if (Input.GetKey("c") && p.puntuacionactual >= 20 )
         {
            lvlc = 2;
            Debug.Log ("Cebo 2" +  lvlc);
           
         }
         if (Input.GetKey("c") && p.puntuacionactual >= 70 ) 
         { 
            lvlc= 3;
            Debug.Log("Cebo 3" + lvlc);
         }
         if (transform.position.y < -239)
         {
            transform.position = new Vector3(transform.position.x, -235f, 0);
         }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Pez")
        {
            MovimientoAutomatico pe = collision.gameObject.GetComponent<MovimientoAutomatico>();
            if (pe != null)
            {
                if(pe.nivelPez <= lvlc)
                {
                    pe.followobject = this.gameObject;
                }
               
            }
        }

        
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pez")
        {
            
        }
    }
}
