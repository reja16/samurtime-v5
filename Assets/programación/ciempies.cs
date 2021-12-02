using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class ciempies : MonoBehaviour
{
    

    [SerializeField] AudioClip sfx_death;
    [SerializeField] float rangodeteccion;

    Animator myAnimator;
    AIPath myAiPath;
    CircleCollider2D myCollider;
    bool Seguir = true;

    float nextFire = 0;

    // Start is called before the first frame update
    void Start()
    {
        //disparo();
        myAnimator = GetComponent<Animator>();
        myCollider = GetComponent<CircleCollider2D>();
        myAiPath = GetComponent<AIPath>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Seguir)
        {
            myAiPath.enabled = Physics2D.OverlapCircle(transform.position, rangodeteccion, LayerMask.GetMask("jugador"));//tamaño radio de detecion
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(255, 0, 0, 0.3f);
        Gizmos.DrawSphere(transform.position, rangodeteccion);//tiene que ser igual a el numero que esta en el update 
    }
    public void DIE()
    {
        AudioSource.PlayClipAtPoint(sfx_death, Camera.main.transform.position);
        //myAiPath.enabled = false;
        Seguir = false;
        myCollider.enabled = false;
        myAnimator.SetTrigger("Dead");
    }

    public void Remove()
    {
        Destroy(gameObject);
    }
    //void disparo()
   // {
        //if (Time.time >= nextFire)
       // {
            //Instantiate(Bala1, disparador.transform.position, disparador.rotation);
            //nextFire = Time.time + fireRate;

            //Instantiate(Bala2, disparador2.transform.position, disparador.rotation);
            //nextFire = Time.time + fireRate;

            //Instantiate(Bala3, disparador.transform.position, disparador.rotation);
            //nextFire = Time.time + fireRate;

            //Instantiate(Bala4, disparador.transform.position, disparador.rotation);
            //nextFire = Time.time + fireRate;
       // }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Activar"))
        {
            
            Debug.Log("Disparar");
        }
    }
}
