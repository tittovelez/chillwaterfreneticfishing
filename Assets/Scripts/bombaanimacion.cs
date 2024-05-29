using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombaanimacion : MonoBehaviour
{
    [SerializeField] private Animator bomba;
    [SerializeField] private string bo = "bo";
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
       if (collision.gameObject.tag == "Pez")
        {
            bomba.SetTrigger(bo);
        }
    }
    public void Desaparecer()
    {
        Destroy(gameObject);
    }
}
