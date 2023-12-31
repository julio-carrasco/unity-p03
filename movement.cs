using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2000.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1.0f;
        }

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;
        rb.velocity = movement * speed * Time.deltaTime;
    }
}
