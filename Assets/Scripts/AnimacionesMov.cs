using UnityEngine;

public class AnimacionesMov : MonoBehaviour
{

    public Animator anim;
    public float acceleration = 5f;
    public float desacceleration = 3f;
    float vel = 0.0f;
    // float speedback = 0.0f;


    void Update()
    {
        Avanzar();
        // Retroceder();
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
    // void Retroceder()
    // {
    //     bool apreteHaciaAtras = Input.GetKey("s");
    //     if(apreteHaciaAtras && speedback<1.0f)
    //     {   vel=0f;
    //         speedback+=Time.deltaTime * acceleration;
    //     }
    //     if(!apreteHaciaAtras && speedback > 0.0f)
    //     {
    //         vel=0f;
    //         speedback-=Time.deltaTime * desacceleration;
    //     }
    //         anim.SetFloat("Speed Backward",speedback);
    //         anim.SetFloat("Speed",vel);
    // }

//     using UnityEngine;

// public class AnimacionesMov : MonoBehaviour
// {

//     public float velocidadMovimiento=5.0f;
//     public float velocidadRotacion = 200.0f;
//     private Animator anim;
//     public float x,y;

//     void Start()
//     {
//         anim = GetComponent<Animator>();
//     }

//     void Update()
//     {
//         x = Input.GetAxis("Horizontal");
//         y = Input.GetAxis("Vertical");

//         transform.Rotate(0,x*Time.deltaTime * velocidadRotacion, 0);
//         transform.Translate(0,0,y*Time.deltaTime * velocidadMovimiento);

//         anim.SetFloat("VelX",x);
//         anim.setFloat("VelY",y);
//     }
// }
}
