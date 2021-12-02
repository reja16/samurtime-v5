using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talismane2 : MonoBehaviour
{
    public GameObject llavera;


    void OnTriggerEnter2D(Collider2D other)
    {
        Jugador.llave3 = true;
        Debug.Log("Llave recogida");

        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Jugador.llave3 = false;
    }

        // Update is called once per frame
        void Update()
        {

        }
    
}
