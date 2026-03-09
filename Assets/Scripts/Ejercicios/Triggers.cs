using TMPro;
using UnityEngine;

public class Triggers : MonoBehaviour
{
    private Vector2 initialPosition;

    //Trampa desaparace:
    [SerializeField] private GameObject Trampa;

    //Trampa Collider se desactiva:
    [SerializeField] private Collider2D Collider;

    //Se pueden referenciar scripts enteros con el nombre directamente, el scrpt puede tener un comprtamiento que podemos "detener" al deshabilitarlo o manipular otros parámetros:
    [SerializeField] private TrampaGiratoria ScriptTrampa;

    //Score + Vidas en UI simple:
    private int score = 0;
    private int vidas = 3;
    [SerializeField] private TextMeshProUGUI textScore;
    [SerializeField] private TextMeshProUGUI textVidas;
    [SerializeField] private GameObject buttonRetry;

    //Teletransportador:
    private GameObject currentTeleporter;
    private Rigidbody2D rb;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D elOtro)
    {
        //Los objetos deben usar su correspondiente tag para diferenciar los comportamientos de los Trigger
        if(elOtro.gameObject.CompareTag("Moneda"))
        {
            Destroy(elOtro.gameObject);
            score++;
            textScore.text = "Score: " + score;
        }
        else if(elOtro.gameObject.CompareTag("Trampa"))
        {
            vidas--;
            textVidas.text = "Vidas: " + vidas;
            if (score <= 0)
            {
                Destroy(this.gameObject);
                buttonRetry.SetActive(true);
            }
            else
            {
                transform.position = initialPosition;
            }                
        }

        //Destruir objeto referenciado:
        else if (elOtro.gameObject.CompareTag("ApagarTrampa"))
        {
            Destroy(Trampa);
        }

        //Apagar Componente referenciado:
        else if (elOtro.gameObject.CompareTag("ApagarTrampa"))
        {
            Collider.enabled = false;
        }
        //Apagar Script referenciado:
        else if (elOtro.gameObject.CompareTag("ApagarTrampa"))
        {
            ScriptTrampa.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("teleport"))
        {
            currentTeleporter = collision.gameObject;
            Teleport2 portalScript = collision.GetComponent<Teleport2>();
            if (portalScript != null)
            {
                rb.gravityScale = portalScript.gravity;
            }
        }

    }
}
