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
