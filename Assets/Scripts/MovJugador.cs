using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 100f;
    public Animator anim;
    float vel = 0.0f;
    float speedback = 0.0f;
    public float acceleration = 5f;
    public float desacceleration = 3f;
    void Update()
    {
        Avanzar();
        MovimientoJugador();
        CheckRotation();

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
        var rotation = Input.GetAxisRaw("Mouse X") * rotateSpeed * Time.deltaTime * 500;

        transform.Rotate(0f, rotation, 0f);
    }

    void Avanzar()
    {
        bool apreteHaciaAdelante = Input.GetKey("w");

        if(apreteHaciaAdelante && vel<1.0f)
        {
            vel+=Time.deltaTime * acceleration;
        }
        if(!apreteHaciaAdelante && vel > 0.0f)
        {
            vel-=Time.deltaTime * desacceleration;
        }
            anim.SetFloat("Speed",vel);
    }
    void Retroceder()
    {
        bool apreteHaciaAdelante = Input.GetKey("s");

        if(apreteHaciaAdelante && speedback<1.0f)
        {
            speedback+=Time.deltaTime * acceleration;
        }
        if(!apreteHaciaAdelante && speedback > 0.0f)
        {
            speedback-=Time.deltaTime * desacceleration;
        }
            anim.SetFloat("Speed Backward",speedback);
    }
}

