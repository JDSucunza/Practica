using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    
    public GameObject balaClonada;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("DispararBala")){
            Instantiate (balaClonada);
        }
    }
}
