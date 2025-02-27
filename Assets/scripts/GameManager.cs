using UnityEngine;
using UnityEngine.SceneManagement;  // Para poder cargar escenas (si es necesario reiniciar la escena)
using UnityEngine.UI;  // Para manejar los botones

public class GameManager : MonoBehaviour
{
    public GameObject player;  // El objeto del jugador
    private Vector2 initialPosition;  // La posici�n inicial del jugador

    void Start()
    {
        // Guardamos la posici�n inicial del jugador cuando inicia el juego
        initialPosition = player.transform.position;
    }

    // Esta funci�n se llamar� cuando el bot�n de reinicio sea presionado
    public void RestartGame()
    {
        // Restablece la posici�n del jugador a la inicial
        player.transform.position = initialPosition;

        // Si quieres reiniciar la escena, descomenta la siguiente l�nea:
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
