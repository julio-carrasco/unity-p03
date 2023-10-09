using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speed : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed_mod = 5.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 speedVector = new Vector3(moveHorizontal, 0.0f, moveVertical) * speed_mod;

        // Log the speed vector and the key pressed.
        Debug.Log("Key Pressed: " + GetKeyPressed() + ", Speed Vector: " + speedVector.ToString());
    }

    // Helper function to get the key pressed as a string.
    private string GetKeyPressed()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            return "Left";
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            return "Right";
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            return "Up";
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            return "Down";
        }

        return "None";
    
    }
}