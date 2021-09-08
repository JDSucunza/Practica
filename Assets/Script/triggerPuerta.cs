using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerPuerta : MonoBehaviour
{
    
    public GameObject objetivo;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (){
        objetivo.transform.Translate (0,0,10);
    }
}
