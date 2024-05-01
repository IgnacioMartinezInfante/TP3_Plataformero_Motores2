using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Arriba_Abajo : MonoBehaviour
{
    public float movementDistance = 1f; // Distancia de cada movimiento
    public float movementSpeed = 2f; // Velocidad de movimiento
    public bool startToBottom = true; // Indica si el movimiento comienza hacia abajo

    private Vector3 originalPosition; // Posición inicial del objeto
    private float direction = 1f; // Dirección del movimiento (1 hacia abajo, -1 hacia arriba)

    private void Start()
    {
        // Guardar la posición inicial del objeto
        originalPosition = transform.position;

        // Establecer la dirección inicial según la opción del inspector
        direction = startToBottom ? -1f : 1f;
    }

    private void Update()
    {
        // Calcular el desplazamiento vertical basado en la dirección y la velocidad
        float movement = direction * movementSpeed * Time.deltaTime;

        // Mover el objeto en la dirección calculada
        transform.Translate(new Vector3(0f, movement, 0f));

        // Verificar si el objeto ha alcanzado el límite superior o inferior
        if (Mathf.Abs(transform.position.y - originalPosition.y) >= movementDistance)
        {
            // Cambiar la dirección del movimiento.
            direction = -direction;
        }
    }
}
