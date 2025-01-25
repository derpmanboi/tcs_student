using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.VirtualTexturing;

public class movetheboulitpls : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += transform.up * speed; 
        rb.linearVelocity = speed*transform.up;
   
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<movetheboulitpls>() != null)
        {
            return;
        } 
        Destroy(gameObject);  
    }
}

