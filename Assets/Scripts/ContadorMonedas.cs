using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorMonedas : MonoBehaviour
{
    public Text monedastexto; // Referencia al objeto de texto que mostrará la cantidad de monedas.
    private int contarmonedas = 0; // Inicializamos el contador de monedas a 0.

    // Método para aumentar la cantidad de monedas.

    private void Start()
    {
        Updatemonedastexto();
    }
    public void Increasecontarmonedas()
    {
        contarmonedas++;
        Updatemonedastexto(); // Actualizamos el texto en pantalla.
    }

    // Método para actualizar el texto en pantalla con la cantidad actual de monedas.
    private void Updatemonedastexto()
    {
        monedastexto.text = "Monedas: " + contarmonedas.ToString();
    }
}
