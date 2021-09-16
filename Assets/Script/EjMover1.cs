using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjMover1 : MonoBehaviour
{
    
    public Rigidbody objetivo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Explotar")){
            objetivo.AddRelativeForce (0,0,100);
        }
    }
}
