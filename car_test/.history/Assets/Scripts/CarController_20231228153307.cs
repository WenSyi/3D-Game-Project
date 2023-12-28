using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider[] wheels = new WheelCollider[4];
    public float torque = 200;
    void Start()
    {

    }

    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {

            for (int i = 0; i < wheels.Length; i++)
            {

                wheels[i].motorTorque = torque;


            }

        }
        else
        {

            for (int i = 0; i < wheels.Length; i++)
            {

                //wheels[i].motorTorque = 0;

            }

        }

    }
}
