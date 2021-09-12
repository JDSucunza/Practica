using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    
    public float danio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // REVISAR!!!!
    void OnCollisionEnter (Collision c){
        Vida vidaDelObjeto = c.gameObject.GetComponent <Vida>();
        if (vidaDelObjeto.escudo >= danio){
            vidaDelObjeto.escudo = vidaDelObjeto.escudo - danio;
        } else {
            vidaDelObjeto.cantidad = vidaDelObjeto.cantidad - danio;
        }
    }
}
