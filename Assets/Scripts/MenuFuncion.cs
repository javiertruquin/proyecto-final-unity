using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuFuncion : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
