using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertadesbloqueable : MonoBehaviour
{
    public static int enemigosenlazona = 3;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigosenlazona <= 0)
        {
            Destroy(gameObject);
        }
    }
}
