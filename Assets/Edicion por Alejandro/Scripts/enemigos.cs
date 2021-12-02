using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{

    [SerializeField ]public float vidaMax = 3;
    //int daño = -1;
    float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ataque"))
        {
            vidaMax = vidaMax-0.5f;

            if (vidaMax <= 0)
            {
                Muere();
            }
            Debug.Log("Fui tocado");
        }
    }

    public void RecibirDaño()
    {
        
        vidaActual -= -1;

        if (vidaActual <= 0)
        {
            Muere();
        }
    }



    void Muere()
    {
          Destroy(this.gameObject);
          puertadesbloqueable.enemigosenlazona -= 1;
    }
}
