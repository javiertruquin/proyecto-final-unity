
using UnityEngine;

public class RotacionSolar : MonoBehaviour
{
    public Vector3 rotacion = new Vector3(5,5,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * Time.deltaTime);
        
    }
}
