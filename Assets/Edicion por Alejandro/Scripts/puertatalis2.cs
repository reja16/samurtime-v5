using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertatalis2 : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (Jugador.llave3 == true)
        {
            Destroy(gameObject);

            Debug.Log("Puerta abierta");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
