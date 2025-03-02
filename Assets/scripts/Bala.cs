using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidad = 10f;

    void Update()
    {
        transform.Translate(Vector2.right * velocidad * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject); // Destruir la bala si sale de la pantalla
    }
}
