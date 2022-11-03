using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
    public bool Activo = false;
    public float TimerDestroy = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (Activo==true)
        {
            Destroy(gameObject, TimerDestroy);
        }
    }
}
