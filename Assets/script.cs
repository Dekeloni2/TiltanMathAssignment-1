using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Public variable to adjust speed in the Unity Inspector
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movementInput;

    void Start()
    {
        // Get the Rigidbody2D component attached to the GameObject
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from the keyboard (WASD or Arrow Keys)
        // Store the input in the Update method
        movementInput.x = Input.GetAxisRaw("Horizontal");
        movementInput.y = Input.GetAxisRaw("Vertical");

        // Optional: Normalize the input vector to prevent faster diagonal movement
        movementInput.Normalize();
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody in FixedUpdate for physics consistency
        // Set the velocity based on input and speed
        rb.linearVelocity = movementInput * moveSpeed;
    }
}