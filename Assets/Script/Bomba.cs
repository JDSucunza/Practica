using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    
    public GameObject jugador;
    private bool explotar = false;
    
    
    void Awake (){
        Invoke ("Explotar", 2);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Explotar")){
            Destroy (jugador);
            explotar = true;
        }
    }

    void Explotar (){
        explotar = true;
    }

    void OnTriggerStay (Collider c){
        if (explotar){
            Destroy (c.gameObject);
            Destroy (this.gameObject);
        }
    }

}
