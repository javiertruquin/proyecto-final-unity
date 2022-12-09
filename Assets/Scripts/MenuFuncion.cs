using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuFuncion : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
