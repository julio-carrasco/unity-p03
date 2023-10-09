using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed_mod = 1.0f;
    [SerializeField]
    private Vector3 moveDirection = new Vector3(1.5f, 1.0f, 0.0f);
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 startPosition = transform.position;
        startPosition.y = 0.0f;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * speed_mod * Time.deltaTime);
    }
}
