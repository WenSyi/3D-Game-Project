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
        rb.AddForce(transform.forward * inputY * accelerationPower, ForceMode.Acceleration);

        // Apply turning force
        if (inputY != 0) // Only turn when moving forward/backward
        {
            rb.AddTorque(transform.up * inputX * turnPower * inputY, ForceMode.Acceleration);
        }
    }
}
