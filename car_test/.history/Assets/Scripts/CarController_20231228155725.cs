using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class CarController : MonoBehaviour
{

    public enum Axel
    {

        Front,
        Rear

    }

    [Serializable]
    public struct Wheel
    {

        public GameObject wheelModel;
        public WheelCollider wheelCollider;
        public Axel axel;

    }

    public float maxAcceleration = 30.0f;
    public float brakeAcceleration = 50.0f;

    public List<Wheel> wheels;

    float moveInput;

    private Rigidbody carRb;

    void Start()
    {

        carRb = GetComponent<Rigidbody>();

    }

    void Update()
    {

        GetInput();

    }

    void LateUpdate()
    {

        Move();

    }

    void GetInput()
    {

        moveInput = Input.GetAxis("Vertical");

    }

    void Move()
    {

        foreach (var wheel in wheels)
        {

            wheel.wheelCollider.motorTorque = moveInput * 600 * maxAcceleration * Time.deltaTime;

        }

    }

}
