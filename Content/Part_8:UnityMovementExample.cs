using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f; // Ensure this is a float for better precision

    private void HandlePlayerMovement()
    {
        // Get player input for WASD
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            movement += new Vector3(0, 0, 1);  // Forward (Z axis)
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement += new Vector3(0, 0, -1);  // Backward (Z axis)
        }

        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);  // Left (X axis)
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);  // Right (X axis)
        }

        // Normalize the movement vector to prevent faster diagonal movement
        movement = movement.normalized;

        // Apply movement based on the speed
        transform.position += movement * _moveSpeed * Time.deltaTime;
    }

    ///
    //MB
    ///

    void Update()
    {
        HandlePlayerMovement();
    }
}
