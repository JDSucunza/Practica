using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorOleadas : MonoBehaviour
{
    
    public float tiempo;
    public GameObject prefab;
    
    void Awake (){
        InvokeRepeating ("Respawn", tiempo, 0.3f);
    } 
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Respawn (){
        Instantiate (prefab, this.transform.position, this.transform.rotation);
    }
}
