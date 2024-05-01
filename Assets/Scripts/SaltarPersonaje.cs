using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltarPersonaje : MonoBehaviour
{
    public float jumpForce = 1.0f; // Fuerza del salto
    private bool canJump = true; // Controla si el jugador puede saltar o no

    void Update()
    {
        // Verifica si el jugador est� en el suelo y puede saltar
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            // Aplica una fuerza vertical para el salto
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

            // Deshabilita la capacidad de salto temporalmente para evitar saltos m�ltiples en el aire
            canJump = false;
        }
    }

    // Detecta si el jugador est� en el suelo
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("piso"))
        {
            canJump = true; // Permite que el jugador salte cuando toca el suelo
        }
    }
}
