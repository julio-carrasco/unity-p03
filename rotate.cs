using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
    public float rotationSpeed = 1.0f;
    private Transform targetObject;

    void Start()
    {
        targetObject = GameObject.FindWithTag("Sphere").transform;
    }

    void Update()
    {
        transform.LookAt(targetObject);
    }
}
