using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para recargar la escena

public class GameRestart : MonoBehaviour
{
    public void ReiniciarJuego() // Aseg�rate de que es 'public'
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
