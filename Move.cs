﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Move : NetworkBehaviour
{
    public float speed = 5f;
    public Rigidbody rigid;
    
    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");
            Vector3 force = new Vector3(inputH, 0, inputV);

            force = transform.TransformDirection(force);

            rigid.AddForce(force * speed);
        }
    }
}
