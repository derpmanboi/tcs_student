using UnityEngine;

public class baddie : MonoBehaviour
{
    private Rigidbody2D rb;
    private float hp = 100f;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform target = GameObject.FindGameObjectWithTag("Player").transform;
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
