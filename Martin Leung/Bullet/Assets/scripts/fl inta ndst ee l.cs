using System.Collections;
using UnityEngine;

public class flintandsteel : MonoBehaviour
{
    [SerializeField] private Transform camera;
    private AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();

    }


    // Update is called once per frame
    void Update()
    {
        float miniDistance = 5.0f;
        float distance = Vector3.Distance(camera.position, transform.position);
        Debug.Log("Distance: " + distance);
        if (distance < miniDistance)
        {
            Debug.Log("Playing Sound!");
            audio.volume = 1.0f - (distance / miniDistance);
        }
    }
}
