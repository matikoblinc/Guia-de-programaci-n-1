using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciciotrece : MonoBehaviour
{
    const float pagaCuarentaOMenos = 16;
    const float PagaMasDeCuarenta = 20;
    public float horas;
    float extras;
    float multi1;
    float multi2;
    float multi3;
    

    void Start()
    {
        if (horas > 40)
        {
            extras = horas - 40;
            multi1 = extras * PagaMasDeCuarenta;
            multi3 = multi1 + (40 * pagaCuarentaOMenos);

            Debug.Log("El salario es; " + multi3);

        }

        else
        {
            multi2 = horas  * pagaCuarentaOMenos;

            Debug.Log("El salario es: " + multi2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//13. Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera:  
//• Si trabaja 40 horas o menos se le paga $16 por hora(crear una constante para almacenar el 16)
//• Si trabaja más de 40 horas se le paga $16 por cada una de las primeras 40 horas y $20  por cada hora extra. 
//(crear una constante para almacenar el 20)
//Ingresar por Inspector la cantidad de horas trabajadas en la semana, y mostrar por pantalla el salario correspondiente.
