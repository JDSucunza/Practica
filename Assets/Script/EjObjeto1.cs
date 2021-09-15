using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjObjeto1 : MonoBehaviour
{
    
    public GameObject manager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Fire1")){
             private int gameManager = manager.GetComponent <EjManager1>();
           // gameManager.numero = gameManager.numero + 1;
        }
    }
}
