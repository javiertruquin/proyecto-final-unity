using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarCamara : MonoBehaviour
{

    public GameObject camara1ra;
    public GameObject camara3ra;
    public GameObject camaraPanoramica;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            camara1ra.gameObject.SetActive(true);
            camara3ra.gameObject.SetActive(false);
            camaraPanoramica.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            camara1ra.gameObject.SetActive(false);
            camara3ra.gameObject.SetActive(true);
            camaraPanoramica.gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            camara1ra.gameObject.SetActive(false);
            camara3ra.gameObject.SetActive(false);
            camaraPanoramica.gameObject.SetActive(true);
        }
    }
}
