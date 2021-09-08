using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rigbody : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision c){
        Rigidbody rb = c.gameObject.GetComponent <Rigidbody>();
        rb.AddRelativeForce (0,0,100);
    }
}
