using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Izq_Der : MonoBehaviour
{
    public float movementDistance = 1f; // Distancia de cada movimiento
    public float movementSpeed = 2f; // Velocidad de movimiento
    public bool startToRight = true; // Indica si el movimiento comienza hacia la derecha

    private Vector3 originalPosition; // Posición inicial del objeto
    private float direction = 1f; // Dirección del movimiento (1 hacia la derecha, -1 hacia la izquierda)

    private void Start()
    {
        // Guardar la posición inicial del objeto
        originalPosition = transform.position;

        // Establecer la dirección inicial según la opción del inspector
        direction = startToRight ? 1f : -1f;
    }

    private void Update()
    {
        // Calcular el desplazamiento horizontal basado en la dirección y la velocidad
        float movement = direction * movementSpeed * Time.deltaTime;

        // Mover el objeto en la dirección calculada
        transform.Translate(new Vector3(movement, 0f, 0f));

        // Verificar si el objeto ha alcanzado el límite izquierdo o derecho
        if (Mathf.Abs(transform.position.x - originalPosition.x) >= movementDistance)
        {
            // Cambiar la dirección del movimiento
            direction = -direction;
        }
    }
}