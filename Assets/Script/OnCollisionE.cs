using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionE : MonoBehaviour
{
    
    public GameObject objetoADestruir;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void OnCollisionEnter(){
            Destroy (objetoADestruir);
    }

}
