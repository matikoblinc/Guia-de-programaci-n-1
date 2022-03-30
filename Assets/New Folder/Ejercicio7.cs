using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7 : MonoBehaviour
{
    public int n1;
    public int n2;
    public int n3;
    int mayor;

    // Start is called before the first frame update
    void Start()
    {
        if (n1 == 0 || n2 == 0 || n3 == 0)
        {
            Debug.Log("los numeros no deben ser menores a 1");
        }
        else
        {
            if (n1 == n2 && n2 == n3)
            {
                Debug.Log("son los tres iguales");

            }

            else if (n1 > n2 & n1 > n3)
            {
                mayor = n1;
            }

            else if (n2 > n1 & n2 > n3)
            {
                mayor = n2;
            }

            else
            {
                mayor = n3;
            }


            Debug.Log("El numero mas alto es " + mayor);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//7.Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y  num3, muestre el valor del mayor de todos. 
//En caso de igualdad entre los tres imprimir "Los números son iguales".  Test1: num1 = 12, num2 = 4, num3 = 7.Resultado esperado: El mayor número es num1  Test2: num1 = 2, num2 = 65, num3 = 8.Resultado esperado: El mayor número es num2 
//Instituto de Tecnología ORT 
//Carrera de Analista de Sistemas 
//Materia: Taller de herramientas de programación 
//Test3: num1 = 3, num2 = 10, num3 = 28.Resultado esperado: El mayor número es num3  Test4: num1 = 5, num2 = 5, num3 = 5.Resultado esperado: Los números son iguales
