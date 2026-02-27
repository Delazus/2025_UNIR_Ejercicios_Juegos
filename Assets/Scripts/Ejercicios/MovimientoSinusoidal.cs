using UnityEngine;

public class MovimientoSinusoidal : MonoBehaviour
{
    [SerializeField] private float velocidadMovimiento;
    [SerializeField] private float tiempoDeVuelta;

    private float temporizador;
    private Vector3 direccionMovimiento = new Vector3(1, 0, 0);

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(direccionMovimiento * velocidadMovimiento * Time.deltaTime);
        temporizador += 1 * Time.deltaTime;
        if (temporizador > tiempoDeVuelta) //3sg.
        {
            direccionMovimiento *= -1;
            temporizador = 0;
        }
    }
}
