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
        
        // Agregar condicion de velocidad maxima para acelerar!!
        MovimientoPersonaje m = c.gameObject.GetComponent <MovimientoPersonaje>();
        if (m.velocidadMovimiento < 5){
        m.velocidadMovimiento= m.velocidadMovimiento + 5;
        }
        Destroy (gameObject); 
        
    }
}
