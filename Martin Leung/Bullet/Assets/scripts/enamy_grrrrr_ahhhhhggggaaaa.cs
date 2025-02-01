using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enamy_grrrrr_ahhhhhggggaaaa : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject skibidi;
    float sigma = 0f;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        sigma += Time.deltaTime;
        if (sigma > 0.05f)
        {
            Instantiate(skibidi, transform.position, transform.rotation);
            sigma = 0f;
        }
        
    }
}
