using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MiPrimerScript : MonoBehaviour
{
    //int --> Integer (Entero)
    int miNumero = 50;

    //float --> Coma flotante.
    float miDecimal = 4.7f;
    float baseTriangulo = 3.4f;
    float alturaTriangulo = 5.3f;
    float areaTriangulo; //A = b * h / 2
    float vidas = 100;
    //Bool --> Sólo pueden tener valors: true, false.
    bool vF = false;

    //Char --> Solo tiene un caracter
    char miTalla = 'L';

    //String --> Cadenas e texto
    string miCadena = "¡Hola, aventurero!";
  

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hola mundo!");
        Debug.Log("Mi numero vale: " + miNumero); //Ejemplo concatenar
        Debug.Log("El lado de triangulo vale: " + baseTriangulo + " cm");

        //Operaciones: +, -, *, /
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log("El area del triangulo es: " + areaTriangulo);

        //vidas = vias - 5; eso como decir:
        vidas += 5;
        vidas -= 5;
        vidas *= 5;
        vidas /= 5;

        //Incrementar +1 o -1
        vidas++;
        vidas--;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
