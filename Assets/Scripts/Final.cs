using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour
{
    public GameObject jugador; // Referencia al objeto del jugador
    public GameObject meta; // Referencia al objeto de la meta
    public GameObject levelcompletedCanvas;

    private void Start()
    {
        // Configurar gameoverCanvas como falso al inicio del juego
        levelcompletedCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jugador && meta != null)
        {
            levelcompletedCanvas.SetActive(true);
            Time.timeScale = 0f;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name
        }
    }
}
