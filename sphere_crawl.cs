using UnityEngine;

public class sphere_crawl : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed = 5.0f;

    private Rigidbody rb;
    private Transform targetObject;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        targetObject = GameObject.FindWithTag("Sphere").transform;
    }

    void Update()
    {

        Vector3 targetPosition = targetObject.position;
        Vector3 direction = (targetPosition - transform.position).normalized;
        rb.velocity = direction * moveSpeed;
        
    }
}
