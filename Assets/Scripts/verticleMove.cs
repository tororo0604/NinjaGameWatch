﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticleMove : MonoBehaviour
{
    int h = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate(h, 0, 0);
        } else if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate(-h, 0, 0);
        }

    }
}
