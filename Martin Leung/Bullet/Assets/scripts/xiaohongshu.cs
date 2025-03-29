using UnityEngine;

public class xiaohongshu : MonoBehaviour
{
    private AudioSource xia0hongshu;
    [SerializeField] private GameObject dollar;
    [SerializeField] private float AttackingDistance;
    [SerializeField] private float wantabreakfromtheAds;
    private float clok;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform target = GameObject.FindGameObjectWithTag("Player").transform; 
        Vector2 dir = (target.position - transform.position).normalized;
        float dist = Vector2.Distance(target.position, transform.position);
        if (dist < AttackingDistance)
        {
            if (Time.time >= clok) {
                Instantiate(dollar, transform.position + transform.up * 2, transform.rotation);
                clok = Time.time + wantabreakfromtheAds;
             }
        }
    }
}
