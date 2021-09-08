using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueYDesplazamiento2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision c){
        c.gameObject.transform.position = c.gameObject.transform.position + c.gameObject.transform.forward ;
    }
}
