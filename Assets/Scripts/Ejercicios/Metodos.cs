using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metodos : MonoBehaviour
{
    int num1= 4;
    int num2 = 5;
    int suma;
    // Start is called before the first frame update
    void Start()
    {
        SumarDosNumeros();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SumarDosNumeros();
        }
    }

   void SumarDosNumeros()
   {
        suma = num1 + num2;
        Debug.Log("La suma de los dos números es " + suma);
   }
        
}
