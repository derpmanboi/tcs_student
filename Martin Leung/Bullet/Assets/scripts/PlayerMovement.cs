using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
    }

    void FixedUpdate()
    {

        Vector3 position = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            position.y += 0.25f;
        }
        if (Input.GetKey(KeyCode.S))
        {

            position.y -= 0.25f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= 0.25f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += 0.25f;
        }
        transform.position = position;
    }
}
