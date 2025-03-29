using UnityEngine;

public class shootythingyuhyeah : MonoBehaviour

{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform target = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(target.transform, transform.up);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
