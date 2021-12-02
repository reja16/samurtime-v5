using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    [SerializeField] float fireRate;
    [SerializeField] float speed;
    [SerializeField] GameObject AtaqueDerecha;
    [SerializeField] GameObject AtaqueArriba;
    [SerializeField] GameObject AtaqueIzquierda;
    [SerializeField] GameObject AtaqueAbajo;

    [SerializeField] private Transform disparador;
    [SerializeField] public float vida = 3;
    [SerializeField] Text Vida;
    Animator MyAnimator;
    public int ataqueDeEspada = 1;
    float nextFire = 0;
    float vidaMax = 3;

    public Transform puntoDeAtaque;
    public float rangoDeAtaque = 0.5f;
    public LayerMask objetivos;



    public static bool llave1;
    public static bool llave2;
    public static bool llave3;
    public static bool llave4;

    void Start()
    {
        MyAnimator = GetComponent<Animator>();
        MyAnimator.SetBool("arriba", false);
        MyAnimator.SetBool("derecha", false);
        MyAnimator.SetBool("izquierda", false);
        MyAnimator.SetBool("abajo", false);
    }

    // Update is called once per frame
    void Update()
    {
        moverseAni();
        atacar();
        medidorVida();
        //atacarR();
        
            float movH = Input.GetAxis("Horizontal");
            float movV = Input.GetAxis("Vertical");

            Vector2 movimiento = new Vector2(movH * Time.deltaTime * speed, movV * Time.deltaTime * speed);

            transform.Translate(movimiento);
        

        if(llave1 == true)
        {
            Debug.Log("tengo la llave1");

            //Esta es solo la primera llave. Se puede copiar para configurar las otras llaves para VERIFICAR que estan guardadas.
        }
    }
    void medidorVida()
    {
        Vida.text = vida.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.CompareTag("curar"))
            {
                vida = vida + 1.5f;
            }      
        
        if (collision.CompareTag("SuperCurar"))
        {
            
            vida = vida + 3;
        }
    }
    void moverseAni()
    {
        if (Input.GetKey(KeyCode.W))
        {
            MyAnimator.SetBool("Arriba", true);
        }
        else 
            MyAnimator.SetBool("Arriba", false);


        if (Input.GetKey(KeyCode.S))
        {
            MyAnimator.SetBool("Abajo", true);
        }
        else
            MyAnimator.SetBool("Abajo", false);


        if (Input.GetKey(KeyCode.A))
        {
            MyAnimator.SetBool("Izquierda", true);
        }
        else
            MyAnimator.SetBool("Izquierda", false);


        if (Input.GetKey(KeyCode.D))
        {
            MyAnimator.SetBool("Derecha", true);
        }
        else
            MyAnimator.SetBool("Derecha", false);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject objeto = collision.gameObject;

        string bala = objeto.tag;

        if (objeto.tag == "enemigo")
        {
            vida = vida - 0.5f;

            if (vida <= 0)
            {
                Muere();
                SceneManager.LoadScene(3);
            }
            //Debug.Log("Fui tocado");
        }
    }
    void Muere()
    {
        Destroy(this.gameObject);
        
    }
    void atacar()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && Time.time >= nextFire)
        {
            Instantiate(AtaqueArriba, disparador.transform.position, disparador.rotation);
            nextFire = Time.time + fireRate;

            
        }
        

        if (Input.GetKeyDown(KeyCode.DownArrow) && Time.time >= nextFire)
        {
            Instantiate(AtaqueAbajo, disparador.transform.position, disparador.rotation);
            nextFire = Time.time + fireRate;

            
        }
        

        if (Input.GetKeyDown(KeyCode.RightArrow) && Time.time >= nextFire)
        {
            Instantiate(AtaqueDerecha, disparador.transform.position, disparador.rotation);
            nextFire = Time.time + fireRate;

            
        }
        

        if (Input.GetKeyDown(KeyCode.LeftArrow) && Time.time >= nextFire)
        {
            Instantiate(AtaqueIzquierda, disparador.transform.position, disparador.rotation);
            nextFire = Time.time + fireRate;

            
        }
        

    }

    void atacarR()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Collider2D[] golpearEnemigos = Physics2D.OverlapCircleAll(puntoDeAtaque.position, rangoDeAtaque, objetivos);

            foreach(Collider2D enemigo in golpearEnemigos)
            {
                Debug.Log("Te acuchillo");
                //enemigo.GetComponent<enemigos>().RecibirDaño(ataqueDeEspada);
            }
        }
    }

    void romper()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    private void OnDrawGizmosSelected()
    {
        if (puntoDeAtaque == null)
            return;

        Gizmos.DrawWireSphere(puntoDeAtaque.position, rangoDeAtaque);
    }
}
