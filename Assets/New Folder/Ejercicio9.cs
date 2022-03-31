using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string per1;
    public float cant1;
    public string per2;
    public float cant2;
    public string per3;
    public float cant3;
    float total;
    float porcen1;
    float porcen2;
    float porcen3;


    void Start()
    {
        total = cant1 + cant2 + cant3;

        porcen1 = cant1 / total * 100;


        porcen2 = cant2 / total * 100;

        porcen3 = cant3 / total * 100;

        Debug.Log("Nombre: " + per1 + " capital aportado: $ " + cant1 + ", Porcentaje del capital: % " + porcen1 + ", Monto total aportado: $ " + total);

        Debug.Log("Nombre: " + per2 + " capital aportado: $ " + cant2 + ", Porcentaje del capital: % " + porcen2 + ", Monto total aportado: $ " + total);

        Debug.Log("Nombre: " + per3 + " capital aportado: $ " + cant3 + ", Porcentaje del capital: % " + porcen3 + ", Monto total aportado: $ " + total);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//9.Realizá un programa que resuelva el siguiente problema:  
//Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
//Nombre: capital aportado: $ … , Porcentaje del capital: % .... , Monto total aportado: $ …. 
