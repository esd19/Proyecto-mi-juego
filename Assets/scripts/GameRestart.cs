using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para recargar la escena

public class GameRestart : MonoBehaviour
{
    public void ReiniciarJuego() // Asegúrate de que es 'public'
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
