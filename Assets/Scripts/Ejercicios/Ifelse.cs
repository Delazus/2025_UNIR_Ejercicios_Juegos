using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifelse : MonoBehaviour
{
    [SerializeField] int edad;
    [SerializeField] bool carnet;
    [SerializeField] int dinero;
    [SerializeField] bool musica;
    // Start is called before the first frame update
    void Start()
    {
        // El <= es un comparador, se pueden hacer hasta  6:
        // >, <, >=, <=, ==, !=

        //Operadores lógicos
        // && --> and
        // || --> or, se escribe con alt + 124 

        if (edad >= 18)
        {
            Debug.Log("Soy adulto");
            if (carnet == true) {
                Debug.Log("Puedo conducir legalmente");
            }
            else
            {
                Debug.Log("No puedo conducir");
            }
        }

        // && Más restrictivo
        if (edad >= 18 && edad <= 25)
        {
            Debug.Log("Mi edad esta entre 18 y 25");
        }


        // || Menos restrictivo
        if (dinero >= 5 || musica == true)
        {
            Debug.Log("Puedo ingresar");
        }

        // ! Negar la condición
        if (!(edad >= 18 && edad <= 25))
        {
            Debug.Log("Mi edad NO esta entre 18 y 25");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
