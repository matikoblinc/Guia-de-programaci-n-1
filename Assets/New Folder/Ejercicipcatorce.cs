using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicipcatorce : MonoBehaviour
{
    public string letra;
    public int num1;
    public int num2;
    int operacion;

    void Start()
    {
        switch (letra)
        {
            case "s":
                operacion = num1 + num2;
                Debug.Log("El resultado es: " + operacion);
                break;

            case "r":
                operacion = num1 - num2;
                Debug.Log("El resultado es: " + operacion);
                break;

            case "p":
                operacion = num1 * num2;
                Debug.Log("El resultado es: " + operacion);
                break;

            case "d":
                operacion = num1 / num2;
                Debug.Log("El resultado es: " + operacion);
                break;

            default:
                Debug.Log("La letra es incorrecta");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//14. Construir un programa que simule el funcionamiento de una calculadora que puede realizar las cuatro operaciones 
//aritméticas básicas(suma, resta, producto y división) con valores numéricos enteros.
//Se debe especificar la operación que se desea realizar ingresando una letra por Inspector (s para la suma, r para la
//resta, p para el producto y d para la división) y luego, deberán ingresarse dos números enteros para así realizar la 
//operación.Informar el resultado por pantalla.Nota: Se recomienda el empleo de una sentencia switch. 
