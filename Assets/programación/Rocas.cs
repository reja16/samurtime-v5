using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocas : MonoBehaviour
{
    [SerializeField] public float vidaMax = 3;

    float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
        romperse();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ataque"))
        {
            romperse();
        }
    }
    

    public void romperse()
    {
        vidaMax = vidaMax-0.5f;

        if (vidaMax <= 0)
        {
            Muere();
        }
    }

    void Muere()
    {
        Destroy(this.gameObject);

    }
    
}
