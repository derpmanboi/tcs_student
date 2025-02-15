using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baddie : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    private Rigidbody2D rb;
    private float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = target.position - transform.position;
        rb.linearVelocity = target.position - transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boulit")
        {
            hp -= 10f;
            if (hp <= 0) {
                Destroy(gameObject);
            }
        }
    }
}
