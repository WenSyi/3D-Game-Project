using UnityEngine;

public class controller : MonoBehaviour
{
    public float accelerationPower = 5f;
    public float turnPower = 2f;
    private Rigidbody rb;
    private float inputX, inputY;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get input from keyboard
        inputX = Input.GetAxis("Horizontal"); // A and D keys or Left and Right arrows
        inputY = Input.GetAxis("Vertical"); // W and S keys or Up and Down arrows
    }

    void FixedUpdate()
    {
        // Apply forward force
        if (inputY != 0)
        {
            rb.AddForce(transform.forward * inputY * accelerationPower, ForceMode.Force);
        }

        // Handling turning
        if (inputX != 0 && rb.velocity.magnitude > 0.1f) // Add a threshold to prevent turning when the car is almost stopped
        {
            // Calculate the angle to rotate based on turn power and speed
            float turnAngle = inputX * turnPower * Time.fixedDeltaTime * rb.velocity.magnitude;

            // Rotate around the vertical axis at the position of the rear wheels
            rb.transform.RotateAround(rb.transform.position - rb.transform.forward * 1.5f, Vector3.up, turnAngle);
        }
    }
}
