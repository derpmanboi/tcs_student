using UnityEngine;

public class audio : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private AudioSource bgMusic;
    [SerializeField] private Transform cameraTransform;
    void Start()
    {
        bgMusic = GetComponent<AudioSource>();
        bgMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, 0);
    }
}
