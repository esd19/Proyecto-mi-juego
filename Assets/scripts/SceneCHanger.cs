using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para manejar escenas

public class SceneChanger : MonoBehaviour
{
    public void CambiarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
