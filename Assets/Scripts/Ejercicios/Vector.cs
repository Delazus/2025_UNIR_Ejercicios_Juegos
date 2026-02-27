using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectores : MonoBehaviour
{
    int num = 5;

    Vector3 miEscala = new Vector3 (5, 3, 9);
    Vector3 direccionHaciaTesoro = new Vector3(1 ,4, 0);
    Vector3 paso1;
    // Start is called before the first frame update
    void Start()
    {
        //Siempre el nuevo dato hay que almasenarlo en una variable: paso1 = ...
        paso1 = direccionHaciaTesoro.normalized * 3 ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
