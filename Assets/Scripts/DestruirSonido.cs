using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirSonido : MonoBehaviour
{
    public float SpawnTimeSonido = 1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, SpawnTimeSonido);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
