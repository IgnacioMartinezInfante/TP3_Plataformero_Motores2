using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_Izq_Der : MonoBehaviour
{
    public float movementDistance = 1f; // Distancia de cada movimiento
    public float movementSpeed = 2f; // Velocidad de movimiento
    public bool startToRight = true; // Indica si el movimiento comienza hacia la derecha

    private Vector3 originalPosition; // Posici�n inicial del objeto
    private float direction = 1f; // Direcci�n del movimiento (1 hacia la derecha, -1 hacia la izquierda)

    private void Start()
    {
        // Guardar la posici�n inicial del objeto
        originalPosition = transform.position;

        // Establecer la direcci�n inicial seg�n la opci�n del inspector
        direction = startToRight ? 1f : -1f;
    }

    private void Update()
    {
        // Calcular el desplazamiento horizontal basado en la direcci�n y la velocidad
        float movement = direction * movementSpeed * Time.deltaTime;

        // Mover el objeto en la direcci�n calculada
        transform.Translate(new Vector3(movement, 0f, 0f));

        // Verificar si el objeto ha alcanzado el l�mite izquierdo o derecho
        if (Mathf.Abs(transform.position.x - originalPosition.x) >= movementDistance)
        {
            // Cambiar la direcci�n del movimiento
            direction = -direction;
        }
    }
}