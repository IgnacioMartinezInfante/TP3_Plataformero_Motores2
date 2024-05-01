using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 10.0f; // Velocidad de movimiento
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Movimiento lateral (izquierda y derecha)
        float movimientoCostados = Input.GetAxis("Horizontal") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(movimientoCostados, 0, 0);

        // Movimiento hacia adelante y hacia atrás
        float movimientoVertical = Input.GetAxis("Vertical") * velocidadMovimiento * Time.deltaTime;
        transform.Translate(0, 0, movimientoVertical);
    }
}
