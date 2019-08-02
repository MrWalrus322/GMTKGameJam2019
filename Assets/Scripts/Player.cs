﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rigidBody;
    public float maxSpeed;
    public float acceleration;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        rigidBody.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Debug.Log(rigidBody.velocity.magnitude);
        if (Input.GetKey(KeyCode.W))
        {
            if (rigidBody.velocity.magnitude <= maxSpeed )
            {
                rigidBody.AddRelativeForce(0, 0, acceleration);
            }
        }
        
    }
}
