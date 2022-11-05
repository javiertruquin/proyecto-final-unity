using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayoSetActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.gameObject.tag=="Jugador")
        {
            gameObject.SetActive(true);
        }
        else { gameObject.SetActive(false); }
    }
}
