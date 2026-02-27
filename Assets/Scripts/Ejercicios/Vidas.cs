using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    //Serializar hace visible la variable
    [SerializeField] int vidas = 100;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Empiezo con: " + vidas + "vidas");
        vidas -= 20;
        Debug.Log("Ahora tengo: " + vidas + "vidas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
