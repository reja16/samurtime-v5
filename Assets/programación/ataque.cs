using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{
    [SerializeField] float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempodevida();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.CompareTag("ataque");
    }

    
    void tiempodevida()
    {
        Destroy(gameObject, tiempo);
    }
}
