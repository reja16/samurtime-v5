using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cambio();
        
    }
    void cambio()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localPosition = new Vector2(0.14f, 3.27f);
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localPosition = new Vector2(-0.14f, -3.27f);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.localPosition = new Vector2(2.74f, -0.53f);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.localPosition = new Vector2(-2.74f, -0.53f);
        }
    }
}
