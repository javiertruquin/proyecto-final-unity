using UnityEngine;

public class InteractuarObjetos : MonoBehaviour
{
    public GameObject BigGuy;
    public GameObject YouVeGotSomething;
    public GameObject SonidoFold;
    public float timerRecoger= 0f;
    public int espacioActual = 0;
    public int espacioMaximo = 3;
    public bool variableDebug=false;
    public Animator anim;
    public bool estaAgarrando=false;

    void Start()
    {
        
    }

    void Update()
    {
    }

    void OnTriggerStay(Collider col)
    {  
        if(Input.GetKey(KeyCode.E))
        {
            if(col.transform.gameObject.tag == "ObjChico")
            {
                if(espacioMaximo-espacioActual>=1)
                {
                    timerRecoger+=Time.deltaTime;
                    // estaAgarrando=true;
                    // anim.SetBool("estaAgarrando",estaAgarrando);
                    if(variableDebug==false)
                    {
                        Debug.Log("Recogiendo Objeto");
                        variableDebug=true;
                    }
                    if(timerRecoger>=1f)
                    {
                        Instantiate(SonidoFold);
                        Debug.Log("Objeto Chico Recogido");
                        timerRecoger=0f;
                        col.transform.gameObject.SetActive(false);
                        espacioActual+=1;
                        variableDebug=true;
                    }
                }else
                {
                    Debug.Log("No puedo Recoger este Objeto");
                }
            }
            if(col.transform.gameObject.tag == "ObjMediano")
            {
                if(espacioMaximo-espacioActual>=2)
                {
                    timerRecoger+=Time.deltaTime;
                    // estaAgarrando=true;
                    // anim.SetBool("estaAgarrando",estaAgarrando);
                    if(variableDebug==false)
                    {
                        Debug.Log("Recogiendo Objeto");
                        variableDebug=true;
                    }
                    if(timerRecoger>=2f)
                    {
                        Instantiate(SonidoFold);
                        Debug.Log("Objeto Mediano Recogido");
                        timerRecoger=0f;
                        col.transform.gameObject.SetActive(false);
                        espacioActual+=2;
                        variableDebug=true;

                    }
                }else
                {
                    Debug.Log("No puedo Recoger este Objeto");
                }
            }
            if(col.transform.gameObject.tag == "ObjGrande")
            {
                if(espacioMaximo-espacioActual>=3)
                {
                    timerRecoger+=Time.deltaTime;
                    // estaAgarrando=true;
                    // anim.SetBool("estaAgarrando",estaAgarrando);
                    if(variableDebug==false)
                    {
                        Debug.Log("Recogiendo Objeto");
                        variableDebug=true;
                    }
                    if(timerRecoger>=3f)
                    {
                        Instantiate(BigGuy);
                        Instantiate(SonidoFold);
                        Debug.Log("Objeto Grande Recogido");
                        timerRecoger=0f;
                        col.transform.gameObject.SetActive(false);
                        espacioActual+=3;
                        variableDebug=true;
                    }
                }else
                {
                    if(variableDebug==false)
                    {
                        Debug.Log("No puedo Recoger este Objeto");
                        variableDebug=true;
                    }
                }
            }
            if(col.transform.gameObject.tag == "Depositar")
            {
                if(espacioActual>0)
                {
                    Instantiate(YouVeGotSomething);
                    Debug.Log("Felicidades!!! Recuperaste Algo!!!");
                    espacioActual=0;
                }else
                {
                    if(variableDebug==false)
                    {
                        Debug.Log("No Tienes Objetos");
                        variableDebug=true;
                    }
                }
            }
        }else
        {
            timerRecoger=0f;
            variableDebug=false;
            // estaAgarrando=false;
            // anim.SetBool("estaAgarrando",estaAgarrando);


        }
    }
}
