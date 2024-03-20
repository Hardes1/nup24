using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this value to control the speed of movement
    public float flySpeed = 5f; // Adjust this value to control the speed of movement

    private bool _isDead;
    // Start is called before the first frame update
    void Start()
    {
        _isDead = false;
    }

    // Update is called once per frame
    void Update()
    {   
        Debug.unityLogger.Log("Update");
        if (Input.GetKey(KeyCode.E))
        {
            Debug.unityLogger.Log("URA");
            if (_isDead)
            {
                transform.Rotate(-90, 0, 0);
            }
            else
            {
                transform.Rotate(90, 0, 0);
            }
            _isDead = !_isDead;
        }
        else
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");
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
