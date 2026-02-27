using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    void Start()
    {
        string[] names = { "Ava", "Barbar", "Carls", "Daisy", "Ernesto"};

        Debug.Log(string.Join(", ", names));

        for (int i = 0; i < 5; i++)
        {
            names[i] += ".";
        }

        Debug.Log(string.Join(" ", names));


    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
