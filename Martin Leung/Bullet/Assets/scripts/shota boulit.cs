using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class shotaboulit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boulit;
    public float shootsped;
    private float tsShot = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Time.time >= tsShot)
            {
                Vector3 playerpos = transform.position + transform.up * 2;
                Instantiate(boulit, playerpos, transform.rotation);
                tsShot = Time.time + shootsped;
            }
                

        }

    }
    private void FixedUpdate()
    {
 
    }
}
