﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,0,speed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0,0,-speed));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed,0,0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed,0,0));
        }
    }
}
