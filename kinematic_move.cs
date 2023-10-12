using UnityEngine;

public class kinematic_move : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0f;

    void Start()
    {
    }

    void Update()
    {
        float horizontalInput = 0f;
        float verticalInput = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalInput = -1.0f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            horizontalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            verticalInput = 1.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            verticalInput = -1.0f;
        }

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput).normalized;
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
