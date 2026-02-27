using UnityEngine;

public class GameObjects : MonoBehaviour
{

    //1.Declarar variaple de la propiedad 
    SpriteRenderer spriteRenderer;




    void Start()
    {
        //Componente transform.
        this.gameObject.transform.position = new Vector2(5, 8);    
        this.gameObject.transform.eulerAngles = new Vector2(90, 45);    
        this.gameObject.transform.localScale = new Vector2(4, 2);
        
        //2. Asignarle el llamado del componente
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //3. Llamar su contenido
            spriteRenderer.color = Color.white;
            spriteRenderer.flipX = true;
            spriteRenderer.sortingOrder = 10;
        }
    }
}
