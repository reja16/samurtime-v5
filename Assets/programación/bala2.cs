using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala2 : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float tiempo;

    Rigidbody2D balacuerpo;
    // Start is called before the first frame update
    void Start()
    {
        tiempodevida();
        balacuerpo = GetComponent<Rigidbody2D>();
        balacuerpo.velocity = new Vector2(speed, 0);//*Time.deltaTime);//derecha
    }

    // Update is called once per frame
    void Update()
    {

    }
    void tiempodevida()
    {
        Destroy(gameObject, tiempo);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject objeto = collision.gameObject;

        string bala = objeto.tag;

        if (objeto.tag == "jugador")
        {
            Destroy(this.gameObject);
        }
    }
}
