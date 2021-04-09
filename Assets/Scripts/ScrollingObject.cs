﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f;
    
    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.left);
        transform.Translate(Vector3.left * speed * Time.deltaTime);    
    }
}
