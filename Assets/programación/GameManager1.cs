using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager1 : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameOverMenu;
    //[SerializeField] Text tiempo;
    float contador;
    float num;
    [SerializeField] bool change;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo();
    }
    void contadorTiempo()
    {
        contador += Time.deltaTime;
        if (contador >= 1f)
        {
            num++;
            //tiempo.text = num.ToString();
            contador = 0;
        }
        if (num >= 43f)
        {

            SceneManager.LoadScene(2);
        }
    }
    public void PasarCinematica()
    {
        SceneManager.LoadScene(2);
    }
}
