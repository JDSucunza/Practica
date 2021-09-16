using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjObjeto2 : MonoBehaviour
{
    
    // Start is called before the first frame update
    
    
    void BuscarManager (){
        GameOBject manager = GameObject.Find ("Manager");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("jump")){
            EjManager1 enemyManager = manager.gameObject.GetComponent <EjManager1>();
            enemyManager.numero = enemyManager.numero + 1;
        }
    }


}
