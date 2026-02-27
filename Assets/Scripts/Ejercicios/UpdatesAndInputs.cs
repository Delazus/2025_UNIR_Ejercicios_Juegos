using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdatesAndInputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Inputs siempre van a ser leidos en el Update.
        //GetKey --> Todos los frames se mantiene, se puede usar para cargar ataques
        //GetKeyDown --> Al presionar una vez, solo en el primer frame
        //GetKeyUp --> Al último frame

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Primer frame en el que pulso espacio");
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Esoty manteniendo pulsado espacio");
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Ultimo frame en el que pulso espacio");
        }

        //Funciona igual para el Mouse
        if (Input.GetMouseButtonDown(0)) //0: izq, 1: der, 2: rueda.
        {
            Debug.Log("Primer Clic izquierdo");
        }
        else if (Input.GetMouseButton(0))
        {
            Debug.Log("Estoy manteniendo presionado el Clic derecho");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Suelto Clic izquierdo");
        }

        //
    }
}
