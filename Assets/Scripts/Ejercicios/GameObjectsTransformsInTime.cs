using UnityEngine;

public class GameObjectsTransformsInTime : MonoBehaviour
{
    //Se recomienda siempre agregar que son variables private, y que no es accesible desde otro script:
    [SerializeField] private float velocidadRotacion;
    [SerializeField] private float velocidadMovimiento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    } 

    float temporizador;
    // Update is called once per frame
    void Update()
    {
        //Manipulacion de transform       
        this.gameObject.transform.Translate (new Vector3(1, 0, 0) * velocidadMovimiento * Time.deltaTime);
        this.gameObject.transform.Rotate (new Vector3(0, 0, 1) * velocidadRotacion * Time.deltaTime);
        this.gameObject.transform.localScale += new Vector3(2, 2, 2) * Time.deltaTime;

        //No es necesario siempre llamar por this.gameObject.transform, el echo de escribir solo transform, hace que se entienda que es el transform del objeto al que esta aplicado este script.
        transform.Translate(new Vector3(1, 0, 0) * velocidadMovimiento * Time.deltaTime);


        //Temporizador
        temporizador += 1 * Time.deltaTime;
        Debug.Log(temporizador);


    }
}
