using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovSinRotar : MonoBehaviour
{
    
    public float velocidadFrontal;
    public float velocidadLateral;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Arriba")){
            transform.Translate (0,0,velocidadFrontal * Time.deltaTime);
        }
        if (Input.GetButton("Abajo")){
            transform.Translate (0,0,- velocidadFrontal * Time.deltaTime);
        }
        if (Input.GetButton ("Izquierda")){
            transform.Translate (- velocidadLateral * Time.deltaTime, 0, 0);
        }
        if (Input.GetButton ("Derecha")){
            transform.Translate (velocidadLateral * Time.deltaTime, 0, 0);
        }
    }
}
