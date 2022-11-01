using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 100f;

    void Update()
    {
        CheckRotation();
        MovimientoJugador();
    }
        
    void MovimientoJugador()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");
        Vector3 inputJugador=new Vector3(movX,0,movY);
        transform.Translate(inputJugador * speed * Time.deltaTime);
    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime;

        transform.Rotate(0f, rotation, 0f);
    }

    
    
}

