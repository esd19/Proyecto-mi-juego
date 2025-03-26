using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * speed; // Mueve la bala hacia adelante
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Aqu� puedes manejar colisiones, como destruir la bala
        Destroy(gameObject);
    }
}
