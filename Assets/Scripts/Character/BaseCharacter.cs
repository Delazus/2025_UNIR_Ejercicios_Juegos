using UnityEngine;

public class BaseCharacter : MonoBehaviour
{
    [SerializeField] float walkSpeed = 5f;
    Rigidbody2D rb2d;

    protected virtual void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    protected virtual void Update()
    {

    }

    protected void Move(Vector2 direction)
    {
        //Move de todas las direcciones:
        //rb2d.position += direction * walkSpeed * Time.deltaTime;

        //Move de eje x:
        rb2d.linearVelocityX = direction.x * walkSpeed;
    }
}
