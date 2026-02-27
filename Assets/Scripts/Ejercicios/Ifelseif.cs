using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ifelseif : MonoBehaviour
{
    [SerializeField] int vidas;
    // Start is called before the first frame update
    void Start()
    {
        if (vidas > 50 && vidas <= 100)
        {
            Debug.Log("Verde");
        }
        else if (vidas > 20 && vidas <= 50) 
        {
            Debug.Log("Naranaja");
        }
        else if (vidas > 0 && vidas <= 20) 
        {
            Debug.Log("Rojo");
        }
        else
        {
            Debug.Log("Muerto");
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
