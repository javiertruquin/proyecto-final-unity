using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 300f;
    public Animator anim;

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
        anim.SetFloat("VelX",movX);
        anim.SetFloat("VelY",movY);

    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime;

        transform.Rotate(0f, rotation, 0f);
    }
    
    
}

