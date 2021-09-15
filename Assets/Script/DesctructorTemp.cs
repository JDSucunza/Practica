using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesctructorTemp : MonoBehaviour
{
    
    public int tiempo;

    void Awake (){
        Invoke ("Destruir", tiempo );
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Destruir (){
        Destroy (this.gameObject);
    }

}
