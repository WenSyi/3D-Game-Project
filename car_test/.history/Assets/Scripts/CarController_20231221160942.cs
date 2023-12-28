using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public Vector3 forward = new Vector3(0, 0, 1);
    public Vector3 backward = new Vector3(0, 0, -1);
    public Vector3 right = new Vector3(1, 0, 0);
    public Vector3 left = new Vector3(-1, 0, 0);

    public float speed = 0f;
    public float driftFactor = 0.95f; // Adjust this for more or less drift
    public float turnSpeed = 5f; // Adjust the turning speed

    private bool turn = false;
    private Rigidbody rigidbody;

    void Start()
    {

        this.rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // Basic movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(this.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(this.backward * speed * Time.deltaTime);
        }

        // Turning
        float turn = 0;
        if (Input.GetKey(KeyCode.A))
        {
            turn = -turnSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            turn = turnSpeed;
        }

        // Drift
        if (Input.GetKey(KeyCode.Space)) // Using space bar for drifting
        {
            // Apply drift factor
            turn *= driftFactor;
        }

        // Apply the turn
        if (rigidbody.GetComponent(speed) == 0)
        {

        }
        transform.Rotate(0, turn, 0);
    }
}
