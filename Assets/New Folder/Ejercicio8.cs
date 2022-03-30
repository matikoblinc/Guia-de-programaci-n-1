using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio8 : MonoBehaviour
{
    public int Día;
    // Start is called before the first frame update
    void Start()
    {

        switch (Día)
        {
            case 1:
                Debug.Log("el día es Domingo");
                break;
            case 2:
                Debug.Log("el día es Lunes");
                break;
            case 3:
                Debug.Log("el día es Martes");
                break;
            case 4:
                Debug.Log("el día es Miercoles");
                break;
            case 5:
                Debug.Log("el día es jueves");
                break;
            case 6:
                Debug.Log("el día es Viernes");
                break;
            case 7:
                Debug.Log("el día es Sabado");
                break;
            default:
                Debug.Log("el valor no es un día de la semana");
                break;
        }
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
