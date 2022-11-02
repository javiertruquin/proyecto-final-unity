using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoPartida : MonoBehaviour
{
    public float tiempoPartida=50f;
    public float tiempoRestante=0f;
    public bool aSalvo=true;

    void Start()
    {
        tiempoRestante=tiempoPartida;
    }

    void Update()
    {
        
        if(tiempoRestante<=0f)
        {
            Debug.Log("Se acabo el tiempo");
            tiempoRestante=0f;
            if(aSalvo)
            {
                Debug.Log("Estas A Salvo");
            }else
            {
                Debug.Log("Estas Muerto");
            }
        }else
        {
            tiempoRestante-=Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider col)
    {

        if(col.transform.gameObject.tag == "Depositar")
        {
            aSalvo=true;
        }

    }
    void OnTriggerExit(Collider col)
    {
        if(col.transform.gameObject.tag == "Depositar")
        {
            aSalvo=false;
        }
    }
}
