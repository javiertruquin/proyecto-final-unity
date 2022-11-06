using UnityEngine;

public class Luces : MonoBehaviour
{
    public GameObject Luz;
    public bool estaPrendido=false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            estaPrendido = !estaPrendido;

        if (estaPrendido)
            Luz.SetActive(true);
        else
            Luz.SetActive(false);
    }
}
