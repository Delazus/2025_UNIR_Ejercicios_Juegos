using System;
using UnityEngine;

public class Metodos_II : MonoBehaviour
{
    // Aquí van solo variables GLOBALES
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Esta es una nueva variable (int resultadoPaso1) a la cual se le asgina el valor que esta siendo obtendio de acuerdo a lo que hace el método.
        int resultadoPaso1 = SumarDosPagas(5, 8);
        string productoObtenido = MaquinaDeSnacks(resultadoPaso1, "A20");
        Debug.Log("He comprado: " + productoObtenido);
    }


    // Update is called once per frame
    void Update()
    {
        
    }


    //El Void significa como es la slaida de la variable, en este caso es vacia, para oder usarla fuera es necesaria convertrla projemeplo a int
    int SumarDosPagas(int num1, int num2) //Parametrizar el metodo: hacer que el metodo tenga los datos al agregarlos en la linea 11, en este caso 5 y 8
    {
        //Variables LOCALES (Solo se pueden acceder desde este método)
        int pagaTotal;
        pagaTotal = num1 + num2;
        Debug.Log("El resultado de la suma es " + pagaTotal);
        return pagaTotal;
        // El anterior return siempre hace que este codigo del meotodo finalice, no importa si escribo mas código debajo de este.
    }

    string MaquinaDeSnacks(float dinero, string codigoProducto)
    {
        string productoObtenido;
        if (dinero >= 1.5f && codigoProducto == "A20")
        {
            productoObtenido = "Cocacola";
        }

        else if (dinero >= 1f && codigoProducto == "K27")
        {
            productoObtenido = "KitKat";
        }

        else if (dinero >= 3f && codigoProducto == "P37")
        {
            productoObtenido = "Kinder";
        }

        else
        {
            productoObtenido = "";
            Debug.Log("No hay dinero suficiente o el código es incorrecto");
        }

        return productoObtenido;

        //Cocacola 1.5 cod = "A20"
        //KitKat 1 cod = "K27"
        //Kinder 1.25 cod "P37"
    }




}
