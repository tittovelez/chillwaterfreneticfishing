using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientobarca : MonoBehaviour
{
    public float movimientofuerza = 2f;
    // Update is called once per frame
    
    private void Start()
    {

    }
    void Update()
    {
        float MovementX = Input.GetAxisRaw("Horizontal");
        Vector2 posicionBarca = transform.position;

     transform.position = posicionBarca + new Vector2(MovementX, 0f) * movimientofuerza * Time.deltaTime;

        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "barrera")
        {
            if (transform.position.x > collision.transform.position.x)
            transform.position = new Vector3 (-7.1f, transform.position.y, 0f);
        }
        if (collision.tag == "barrera 2")
        {
            if (transform.position.x > collision.transform.position.x)
                transform.position = new Vector3(14.02f, transform.position.y, 0f);
        }
    }
}