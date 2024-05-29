using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sirena : MonoBehaviour
{
    public int Index;
    public int _speed = 0;
    private SpriteRenderer _spriteRenderer;
    public List<GameObject> Waypoints;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Index = 0;
    }

    void Update()
    {
        {
            if (transform.position.x < Waypoints[Index].transform.position.x)
            {
                _spriteRenderer.flipY = true;
            }
            else
            {
                _spriteRenderer.flipY = false;
            }
            float distance = Vector3.Distance(transform.position, Waypoints[Index].transform.position);
            if (distance < 0.1f)
            {
                Index++;
                if (Index == Waypoints.Count) Index = 0;
            }
            transform.position = Vector3.MoveTowards(transform.position, Waypoints[Index].transform.position, _speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Anzuelo")
        {
            Debug.Log("fasfasof");
        }
        if (collision.gameObject.tag == "ObjectController")
        {

        }
        if (collision.gameObject.tag == "Pez")
        {
            Destroy(collision.gameObject);
        }
    }
 }