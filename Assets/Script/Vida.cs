using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Vida : MonoBehaviour
{

    public float cantidad;
    public float escudo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cantidad <= 0 ){
            Destroy (gameObject);
        }
    }

    void asignarVida (){
        
        this.cantidad = cantidad;
        this.escudo = escudo;
    }

}
