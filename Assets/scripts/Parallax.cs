using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float velocidadParallax = 0.1f;
    private Transform camara;
    private Vector3 posicionInicial;

    void Start()
    {
        camara = Camera.main.transform;
        posicionInicial = transform.position;
    }

    void Update()
    {
        float desplazamiento = camara.position.x * velocidadParallax;
        transform.position = new Vector3(posicionInicial.x + desplazamiento, posicionInicial.y, posicionInicial.z);
    }
}
