using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LlamarSonidoFold : MonoBehaviour
{ public GameObject SonidoFold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(SonidoFold);
        
    }
}
