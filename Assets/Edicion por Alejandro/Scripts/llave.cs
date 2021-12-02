using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llave : MonoBehaviour
{


    public GameObject llavera;


    void OnTriggerEnter2D(Collider2D other)
    {
        Jugador.llave1 = true;
        Debug.Log("Llave recogida");
 
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Jugador.llave1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
