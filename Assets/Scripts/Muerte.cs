using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muerte : MonoBehaviour
{
    public GameObject gameoverCanvas; // Referencia al Canvas de Game Over en la jerarquía

    private void Start()
    {
        // Configurar gameoverCanvas como falso al inicio del juego
        gameoverCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("muerte")) // Cambia "ObjetoQueCausaGameover" por la etiqueta adecuada
        {
            // Mostrar el Canvas de Game Over y detener el tiempo
            gameoverCanvas.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    // Método para reiniciar la partida (llamado desde un botón en tu UI)
    public void RestartGame()
    {
        Time.timeScale = 1f; // Reanuda el tiempo (reinicia el juego)
        gameoverCanvas.SetActive(false); // Oculta el Canvas de Game Over.
    }
}