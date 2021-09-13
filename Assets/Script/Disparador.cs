using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    
    public float tamanioPrefab;
    public int balas;
    public GameObject prefab;

    public GameObject jugador;
    public string nombreDeAccion;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown (nombreDeAccion)){
            InvokeRepeating ("Disparo",0, 0.2f);
        }

        if (Input.GetButtonUp (nombreDeAccion) || balas == 0){
            CancelInvoke ("Disparo");
        }
    }

    void Disparo (){
        Instantiate (prefab, jugador.transform.position + Vector3.forward,jugador.transform.rotation);
            balas = balas - 1;
    }
    

}
