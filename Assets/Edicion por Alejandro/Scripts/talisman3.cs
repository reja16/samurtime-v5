using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class talisman3 : MonoBehaviour
{
    public GameObject llavera;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("jugador"))
        {
            Jugador.llave4 = true;
            Debug.Log("Llave recogida");

            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Jugador.llave4 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
