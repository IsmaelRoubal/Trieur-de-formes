using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 0.5F;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other){
        other.gameObject.transform.Translate(gameObject.transform.forward * speed);
    }
}
