﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBalas : MonoBehaviour
{
    public float vel = 2.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(vel * Time.deltaTime,0));
    }
}
