using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the speed of movement
    public float flySpeed = 5f; // Adjust this value to control the speed of movement

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate();
        }
        else
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            MoveHorizontally(horizontalInput, verticalInput);
        }
        // Get the user input

        
        // Calculate the movement direction

        // Move the object based on the input
    }

    private void MoveHorizontally(float horizontalInput, float verticalInput)
    {
        Vector3 moveDirection = new Vector3(-horizontalInput, 0f, -verticalInput).normalized;
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
    }

}
