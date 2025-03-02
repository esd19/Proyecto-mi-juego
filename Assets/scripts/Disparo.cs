using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform puntoDisparo;
    public float velocidadBala = 9f;
    public int maxDisparos = 2; // Máximo de disparos antes del cooldown
    public float cooldownTiempo = 0.5f; // Tiempo de espera antes de volver a disparar

    private int disparosRestantes;
    private bool enCooldown = false;

    void Start()
    {
        disparosRestantes = maxDisparos; // Inicialmente, tiene los 2 disparos disponibles
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !enCooldown && disparosRestantes > 0)
        {
            Disparar();
        }
    }

    void Disparar()
    {
        GameObject nuevaBala = Instantiate(balaPrefab, puntoDisparo.position, Quaternion.identity);
        Rigidbody2D rb = nuevaBala.GetComponent<Rigidbody2D>();

        float direccion = transform.localScale.x > 0 ? 1f : -1f;
        rb.linearVelocity = new Vector2(velocidadBala * direccion, 0);
        nuevaBala.transform.localScale = new Vector3(direccion, 1, 1);

        disparosRestantes--; // Reducimos el contador de disparos

        if (disparosRestantes <= 0)
        {
            StartCoroutine(IniciarCooldown());
        }
    }

    IEnumerator IniciarCooldown()
    {
        enCooldown = true;
        yield return new WaitForSeconds(cooldownTiempo);
        disparosRestantes = maxDisparos; // Restauramos la cantidad de disparos
        enCooldown = false;
    }
}
