using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    [SerializeField] GameObject gameOverMenu;
    [SerializeField] Text tiempo;
    float contador;
    float num;
    [SerializeField] bool change;
    

    // Start is called before the first frame update
    void Start()
    {
        
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        PauseGame();
        //contadorTiempo();

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
        if (num >= 1000f)
        {
            
            SceneManager.LoadScene(2);
        }
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void PasarCinematica()
    {
        SceneManager.LoadScene(2);
    }

    public void pasarNivel1()
    {
        SceneManager.LoadScene(3);
    }

    

    void PauseGame()
    {
        //pausar y "despausar" el juego
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
            }
        }
        //setActive
        //variable serializada
    }
    
    }