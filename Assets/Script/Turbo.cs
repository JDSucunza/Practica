using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turbo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider c){
        MovimientoPersonaje m = c.gameObject.GetComponent <MovimientoPersonaje>();
        m.velocidadMovimiento= m.velocidadMovimiento + 50;
        Destroy (gameObject); 
    }
}
