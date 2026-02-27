using UnityEngine;
using static UnityEditor.PlayerSettings.SplashScreen;

public class BaseCharacter : MonoBehaviour
{
    [SerializeField] float linearSpeed = 1f;
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
        rb2d.linearVelocityX += direction.x * linearSpeed * Time.deltaTime;
    }
}
