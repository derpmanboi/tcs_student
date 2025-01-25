using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baddie : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target,Vector3.left);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "boulit")
        {
            Destroy(gameObject);
        }
    }
}
