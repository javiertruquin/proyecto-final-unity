using UnityEngine;

public class Linterna : MonoBehaviour
{
    public GameObject Luz;
    public bool estaPrendido=false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            estaPrendido = !estaPrendido;

        if (estaPrendido)
            Luz.SetActive(false);
        else
            Luz.SetActive(true);
    }
}
