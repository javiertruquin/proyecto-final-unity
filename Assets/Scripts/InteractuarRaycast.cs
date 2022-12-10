using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarRaycast : MonoBehaviour
{
    private new Transform camera;
    public float rayDistance;
    public RaycastHit hit;
    public GameObject mira;
    public GameObject miraInteractuar;
    void Start()
    {
        camera = transform.Find("Camera 1ra");
    }

    void Update()
    {
        // Debug.DrawRay(camera.position, camera.forward * rayDistance,Color.red);

        SearchObject();
    }

    void SearchObject()
    {
        if (Physics.Raycast(camera.position, camera.forward * rayDistance, out hit, rayDistance, LayerMask.GetMask("Interactuable")))
        {
            miraInteractuar.SetActive(true);
            mira.SetActive(false);

        }else
        {
            miraInteractuar.SetActive(false);
            mira.SetActive(true);
        }
        
    }

}
