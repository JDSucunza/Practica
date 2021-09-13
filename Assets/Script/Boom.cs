using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour
{
    
    public float tiempo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Autodestruir (){
        Destroy (gameObject);
    }

    public void awake (){
        Invoke ("Autodestruir", tiempo);
    }
}
