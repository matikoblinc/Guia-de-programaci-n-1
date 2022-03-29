using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    public int num1;
    int resto;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == 0)
        {
            Debug.Log("el numero tiene que ser mayor a cero");
        }

        else
        {
            resto = num1 % 2;

            if (resto > 0)
            {
                Debug.Log("el numero es impar");
            }
            else
            {
                Debug.Log("El numero es par");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
// una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
//par" o "el número es impar. Deberá utilizar el operador “módulo” es el caracter %.