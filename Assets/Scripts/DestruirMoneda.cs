using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirMoneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("jugador"))
        {
            ContadorMonedas contarmonedas = FindObjectOfType<ContadorMonedas>();
            if (contarmonedas != null)
            {
                contarmonedas.Increasecontarmonedas(); // Aumenta el contador de monedas.
            }

            Destroy(gameObject); // Destruye la moneda.
        }
    }
}
