using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarBis : MonoBehaviour
{
    public int espacioActual = 0;
    public int espacioMaximo = 3;
    public float Agarrando = 0;
    public enum ObjetosTipo
    {
     ObjetoChico,
     ObjetoMediano,
     ObjetoGrande,
    }
    public ObjetosTipo  BySize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {    switch (BySize)
        {
            case ObjetosTipo.ObjetoChico:
                break;
            case ObjetosTipo.ObjetoMediano:
                break;
            case ObjetosTipo.ObjetoGrande:
                break;
            default:
                Debug.Log("We need CASH$$$");
                break;
        }
    }
}
