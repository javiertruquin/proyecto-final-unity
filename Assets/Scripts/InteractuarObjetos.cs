using UnityEngine;

public class InteractuarObjetos : MonoBehaviour
{
    public GameObject Searching;
    public GameObject BigGuy;
    public GameObject YouVeGotSomething;
    public GameObject SonidoFold;
    public float timerRecoger= 0f;
    public int espacioActual = 0;
    public int espacioMaximo = 4;
    public Animator anim;
    public bool estaAgarrando=false;

    //Raycast
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
        MiraColor();
        Interactuar();
        Debug.DrawRay(camera.position, camera.forward * rayDistance, Color.blue);
    }

    void MiraColor()
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

    
    void Interactuar()
    {  
        if(Input.GetKey(KeyCode.E))
        {           
            if(Physics.Raycast(camera.position,camera.forward * rayDistance, out hit, rayDistance, LayerMask.GetMask("Interactuable")))
            {
                if (hit.transform.CompareTag("ObjChico"))
                {
                    if(espacioMaximo-espacioActual>=1)
                    {
                        timerRecoger+=Time.deltaTime;
                        Searching.SetActive(true);
                        Debug.Log("Recogiendo Objeto");
                        if(timerRecoger>=1f)
                        {
                            Searching.SetActive(false);
                            SonidoFold.SetActive(true);
                            Debug.Log("Objeto Recogido");
                            timerRecoger=0f;
                            hit.transform.gameObject.SetActive(false);
                            espacioActual+=1;
                        }
                    }else
                    {
                        SonidoFold.SetActive(false);
                        Searching.SetActive(false);
                        Debug.Log("No puedo Recoger este Objeto");
                    }
                }
                if(hit.transform.CompareTag("ObjMediano"))
                {
                    if(espacioMaximo-espacioActual>=2)
                    {
                        timerRecoger+=Time.deltaTime;
                        Searching.SetActive(true);
                        Debug.Log("Recogiendo Objeto");
                        if(timerRecoger>=2f)
                        {
                            Searching.SetActive(false);
                            SonidoFold.SetActive(true);
                            Debug.Log("Objeto Recogido");
                            timerRecoger=0f;
                            hit.transform.gameObject.SetActive(false);
                            espacioActual+=2;
                        }
                    }else
                    {
                        SonidoFold.SetActive(false);
                        Searching.SetActive(false);
                        Debug.Log("No puedo Recoger este Objeto");
                    }
                }
                if(hit.transform.CompareTag("ObjGrande"))
                {
                    if(espacioMaximo-espacioActual>=3)
                    {
                        timerRecoger+=Time.deltaTime;
                        Searching.SetActive(true);
                        Debug.Log("Recogiendo Objeto");
                        if(timerRecoger>=3f)
                        {
                            Searching.SetActive(false);
                            BigGuy.SetActive(true);
                            SonidoFold.SetActive(true);
                            Debug.Log("Objeto Recogido");
                            timerRecoger=0f;
                            hit.transform.gameObject.SetActive(false);
                            espacioActual+=3;
                        }
                    }else
                    {
                        Searching.SetActive(false);
                        SonidoFold.SetActive(false);
                        Debug.Log("No puedo Recoger este Objeto");
                        BigGuy.SetActive(false);
                    }
                }
            }
        }else
        {
            BigGuy.SetActive(false);
            timerRecoger =0f;
            SonidoFold.SetActive(false);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if(col.transform.gameObject.tag == "Depositar")
            {
                if(espacioActual>0)
                {
                    Instantiate(YouVeGotSomething);
                    Debug.Log("Felicidades!!! Recuperaste Algo!!!");
                    espacioActual=0;
                }else
                {  
                    Debug.Log("No Tienes Objetos");
                }
            }
    }
}
