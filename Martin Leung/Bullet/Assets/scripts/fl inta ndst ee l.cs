using System.Collections;
using UnityEngine;

public class flintandsteel : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    private AudioSource audio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    IEnumerator PlaySound(bool randomize = false, float chance = 0.5f, float miniDistance = 1.0f) {
        Vector3 distance = Vector3.Distance(Camera.transform.position, transform.position);
        if { distance < miniDistance}
        {
            audio.volume = 1.0f - (distance / miniDistance)
        }
    } }
