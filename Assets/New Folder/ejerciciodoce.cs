using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciodoce : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    int num1 = 0;

    void Start()
    {
        if (dado1 < 1 || dado2 < 1 || dado3 < 1 || dado1 > 6 || dado2 > 6 || dado3 > 6)
        {
            Debug.Log("algun numero no es correcto");
        }
        else 
            { 
        if (dado1 == 6) num1++;

        if (dado2 == 6) num1++;

        if (dado3 == 6) num1++;

            switch (num1)
            {
                case 1:
                    Debug.Log("Regular");
                    break;
                case 2:
                    Debug.Log("Muy bien");
                    break;
                case 3:
                    Debug.Log("Excelente");
                    break;
                default:
                    Debug.Log("insuficiente");
                    break;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje obtenido en el lanzamiento de 
//tres dados de un cliente, de acuerdo a los siguientes  resultados:  
//• Si los tres dados son seis, mostrar el mensaje “Excelente” 
//• Si dos dados son seis, mostrar el mensaje “Muy bien”  
//• Si un dado es seis, mostrar el mensaje “Regular”  
//• Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 
