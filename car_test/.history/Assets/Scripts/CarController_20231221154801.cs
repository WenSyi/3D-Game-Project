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

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        // move
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(this.forward * speed * Time.deltaTime);
        }

    }
}
