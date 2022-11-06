using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisadas : MonoBehaviour
{
    public GameObject Steps;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { Steps.SetActive(true); }
        if (Input.GetKeyUp(KeyCode.W))
        { Steps.SetActive(false); }
        if (Input.GetKey(KeyCode.A))
        { Steps.SetActive(true); }
        if (Input.GetKeyUp(KeyCode.A))
        { Steps.SetActive(false); }
        if (Input.GetKey(KeyCode.S))
        { Steps.SetActive(true); }
        if (Input.GetKeyUp(KeyCode.S))
        { Steps.SetActive(false); }
        if (Input.GetKey(KeyCode.D))
        { Steps.SetActive(true); }
        if (Input.GetKeyUp(KeyCode.D))
        { Steps.SetActive(false); }
    }
   

}

