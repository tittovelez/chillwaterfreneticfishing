using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombas : MonoBehaviour
{
    [SerializeField] public float radio;
    [SerializeField] public float fuerzaExplosion;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            Explosion();
        }
    }
    public void Explosion()
    {
        Collider2D[] objetos = Physics2D.OverlapCircleAll(transform.position, radio);
        foreach (Collider2D colisionador in objetos)
        {
            Rigidbody2D rb2D = colisionador.GetComponent<Rigidbody2D>();
            if (rb2D != null )
            {
                Vector2 direccion = colisionador.transform.position - transform.position;
                float distancia = 1 + direccion.magnitude;
                float fuerzaFinal = fuerzaExplosion / distancia;    
                rb2D.AddForce(direccion * fuerzaFinal); 
            }
        }
        Destroy (gameObject);
    }
    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radio);
    }



}
