﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    int num1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        num1 += 2;
        Debug.Log(" el valor al sumar 2 es " + num1);
        num1 = num1 * num1;
        Debug.Log(" el valor al al multiplicarlo por si mismo es " + num1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//1. Realizá un programa donde se cree una variable entera llamada num1, que inicialmentevaldrá 0.
// Luego incrementá su valor en 2 y mostralo por pantalla. Después mostrá elresultado de multiplicarlo por sí mismo.