﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balbalbal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c){
        c.transform.Translate(0, 0, 10);
    } 
}