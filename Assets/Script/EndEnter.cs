﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndEnter : MonoBehaviour
{
    public int speed = -10 ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, -10);
    }
}
