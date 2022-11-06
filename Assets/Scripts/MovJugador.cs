using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float speed = 10f;
    public float rotateSpeed = 300f;
    public Animator anim;
    // public Rigidbody rb;

    void Update()
    {
        CheckRotation();
        MovimientoJugador();
    }
        
    void MovimientoJugador()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical") ;
        Vector3 inputJugador=new Vector3(movX,0,movY);
        // Vector3 inputJugador2=new Vector3(0,0,movY);
        // rb.AddForce(inputJugador,ForceMode.Impulse);
        // rb.AddForce(inputJugador2,ForceMode.Impulse);
        

        transform.Translate(inputJugador* speed * Time.deltaTime);

        anim.SetFloat("VelX",movX);
        anim.SetFloat("VelY",movY);

    }

    void CheckRotation()
    {
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0f, rotation, 0f);
    }
    
    
}

