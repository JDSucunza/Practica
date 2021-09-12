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
        if (Input.GetButtonDown (nombreDeAccion) && balas > 0){
            Instantiate (prefab, jugador.transform.position + Vector3.forward * tamanioPrefab,jugador.transform.rotation);
            balas = balas - 1;
        }
    }
    

}
