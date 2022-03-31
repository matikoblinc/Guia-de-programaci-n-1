using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicioonce : MonoBehaviour
{
    
    public string fechaCompra;
    public string nombreComprador;
    public string productoSolicitado;
    public string cantidadSolicitada;
    public string precioUnidad;


    void Start()
    {
        string[] ArrayDeMensajes = { fechaCompra, nombreComprador, productoSolicitado, cantidadSolicitada, precioUnidad };
        string[] ArrayComentario = { "Fecha de Compra: ", "Nombre del Comprador ", "Producto solicitado: ", "Cantidad solicitada: ", "Precio Unitario: $", "Total a Pagar: $"};

        for (int i = 0; i != 6; i++)
        {
            Debug.Log(ArrayComentario[i] + ArrayDeMensajes[i]);
    }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
