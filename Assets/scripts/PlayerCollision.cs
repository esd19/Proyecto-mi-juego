using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            Debug.Log("Colisión con la pared: movimiento bloqueado.");
        }

        if (collision.gameObject.CompareTag("Piso"))
        {
            Debug.Log("El personaje está en el suelo.");
        }
    }
}
