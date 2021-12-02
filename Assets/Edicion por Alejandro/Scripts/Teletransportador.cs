using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public GameObject objetivoSpawn;
    public GameObject jugador;

    void OnTriggerEnter2D(Collider2D other)
    {
        jugador.transform.position = objetivoSpawn.transform.position;

        Debug.Log("Tp?");
        //  Lerp (jugador, objetivoSpawn, 0.05); )
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
