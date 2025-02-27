using UnityEngine;
using UnityEngine.SceneManagement;  // Para poder cargar escenas (si es necesario reiniciar la escena)
using UnityEngine.UI;  // Para manejar los botones

public class GameManager : MonoBehaviour
{
    public GameObject player;  // El objeto del jugador
    private Vector2 initialPosition;  // La posición inicial del jugador

    void Start()
    {
        // Guardamos la posición inicial del jugador cuando inicia el juego
        initialPosition = player.transform.position;
    }

    // Esta función se llamará cuando el botón de reinicio sea presionado
    public void RestartGame()
    {
        // Restablece la posición del jugador a la inicial
        player.transform.position = initialPosition;

        // Si quieres reiniciar la escena, descomenta la siguiente línea:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
