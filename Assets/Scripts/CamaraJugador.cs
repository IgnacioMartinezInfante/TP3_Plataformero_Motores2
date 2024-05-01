using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraJugador : MonoBehaviour
{
    public Transform jugador; // Referencia al transform del jugador
    public float distanciaZ = 10f; // Distancia de la cámara al jugador en el eje Z
    public float altura = 5f; // Altura de la cámara sobre el jugador

    void LateUpdate()
    {
        if (jugador != null)
        {
            // Calcula la posición deseada de la cámara
            Vector3 posicionDeseada = jugador.position - jugador.forward * distanciaZ + Vector3.up * altura;

            // Posiciona la cámara
            transform.position = Vector3.Lerp(transform.position, posicionDeseada, Time.deltaTime * 5f);

            // La cámara mira al jugador
            transform.LookAt(jugador.position);
        }
    }
}
