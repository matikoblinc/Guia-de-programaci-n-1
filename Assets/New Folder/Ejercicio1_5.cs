using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_5 : MonoBehaviour
{
    public int num1;
    bool estaEnA;
    bool estaEnB;
    bool estaEnAmbos;
    bool noEstaEnNinguno;
    int num2;

    void Start()
    {
        if (num1 == 0)
        {
            Debug.Log("el numero no es par o impar");
        }
        else if (num1 < 0)
        {
            Debug.Log("el numero debe ser mayor a cero");
        }

        else
        {
            if (num1 < 10)
            {
                estaEnA = true;
            }

            num2 = num1 % 2;
            if (num2 > 0)
            {
                estaEnB = true;
                if (num1 > 10)
                {
                    estaEnB = false;
                }
            }

            if (estaEnA == true && estaEnB == true)
            {
                estaEnAmbos = true;
            }

            if (estaEnA != true && estaEnB != true)
            {
                noEstaEnNinguno = true;
            }

            switch (estaEnAmbos)
            {
                case true:
                    Debug.Log("Entra dentro de ambas categorías");
                    break;

                case false:
                    switch (noEstaEnNinguno)
                    {
                        case true:
                            Debug.Log("No entra en ninguna categoría");
                            break;

                        case false:
                            switch (estaEnA)
                            {
                                case true:
                                    Debug.Log("El numero tiene un solo digito");
                                    break;

                                case false:
                                    switch (estaEnB)
                                    {
                                        case true:
                                            Debug.Log("El numero es impar");
                                            break;
                                    }
                                    break;
                            }
                            
                            break;
                    }
                   
                    break;

            }
        }



    }



    // Update is called once per frame
    void Update()
    {

    }
}

//15.Existen dos reglas que identifican dos conjuntos de valores: 
//-El número es de un solo dígito.  
//- El número es impar.  
//A partir de estas reglas, creá un algoritmo que asigne a las variables booleanas estaEnA, estaEnB, estaEnAmbos y noEstaEnNinguno
//el valor verdadero o falso, según corresponda, para indicar si el valor ingresado pertenece al primer conjunto, al segundo, a ambos
//o a  ninguno, respectivamente. Definí un lote de prueba de varios números y probá el algoritmo, escribiendo los resultados. 
