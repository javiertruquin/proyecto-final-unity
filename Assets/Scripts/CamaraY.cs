using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraY : MonoBehaviour
{

    public float mouseSensitibity = 300f;
    public int arriba=-90;
    public int abajo=40;
    float xRotation = 0;
    
    void Start()
    {   
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitibity * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, arriba, abajo);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
