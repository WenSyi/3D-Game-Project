using UnityEngine;

public class CarController : MonoBehaviour
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
        if (inputX != 0)
        {
            float turnSpeed = Mathf.Lerp(0, turnPower, rb.velocity.magnitude / 10); // Adjust turn speed based on current speed
            rb.AddTorque(transform.up * inputX * turnSpeed, ForceMode.Force);
        }
    }
}
