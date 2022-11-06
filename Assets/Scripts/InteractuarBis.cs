using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractuarBis : MonoBehaviour
{
    [SerializeField] public Collider other;
    public GameObject Searching;
    public GameObject BigGuy;
    public GameObject YouVeGotSomething;
    public GameObject SonidoFold;
    public float timerRecoger = 0f;
    public int espacioActual = 0;
    public int espacioMaximo = 3;
    public bool variableDebug = false;
    public Animator anim;
    public bool estaAgarrando = false;
    public enum ObjetosTipo
    {
     ObjetoChico,
     ObjetoMediano,
     ObjetoGrande,
    }
    public ObjetosTipo  BySize;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            switch (other.transform.gameObject.tag)
            {
                case "ObjChico":
                    ObjetoChico();
                    break;
                case "ObjMediano":
                    ObjetoMediano();
                    break;
                case "ObjGrande":
                    ObjetoGrande();
                    break;
                case "Depositar":
                    Deposita();
                    break;
                default:
                    Debug.Log("We need CASH $$$");
                    break;
            }
        }
        else
        {
            BigGuy.SetActive(false);
            timerRecoger = 0f;
            variableDebug = false;
            // estaAgarrando=false;
            // anim.SetBool("estaAgarrando",estaAgarrando);
            SonidoFold.SetActive(false);

        }
    }
    void ObjetoChico()
    {
        if (espacioMaximo - espacioActual >= 1)
        {
            timerRecoger += Time.deltaTime;
            // estaAgarrando=true;
            // anim.SetBool("estaAgarrando",estaAgarrando);
            if (variableDebug == false)
            {
                Searching.SetActive(true);
                Debug.Log("Recogiendo Objeto");
                variableDebug = true;
            }
            if (timerRecoger >= 1f)
            {
                Searching.SetActive(false);
                SonidoFold.SetActive(true);
                Debug.Log("Objeto Chico Recogido");
                timerRecoger = 0f;
                other.transform.gameObject.SetActive(false);
                espacioActual += 1;
                variableDebug = true;
            }
        }
        else
        {
            Searching.SetActive(false);
            SonidoFold.SetActive(false);
            Debug.Log("No puedo Recoger este Objeto");
        }
    }
    void ObjetoMediano()
    {
        if (espacioMaximo - espacioActual >= 2)
        {
            timerRecoger += Time.deltaTime;
            // estaAgarrando=true;
            // anim.SetBool("estaAgarrando",estaAgarrando);
            if (variableDebug == false)
            {
                Searching.SetActive(true);
                Debug.Log("Recogiendo Objeto");
                variableDebug = true;
            }
            if (timerRecoger >= 2f)
            {
                Searching.SetActive(false);
                SonidoFold.SetActive(true);
                Debug.Log("Objeto Mediano Recogido");
                timerRecoger = 0f;
                other.transform.gameObject.SetActive(false);
                espacioActual += 2;
                variableDebug = true;

            }
        }
        else
        {
            SonidoFold.SetActive(false);
            Searching.SetActive(false);
            Debug.Log("No puedo Recoger este Objeto");
        }
    }
    void ObjetoGrande()
    {
        if (espacioMaximo - espacioActual >= 3)
        {
            timerRecoger += Time.deltaTime;
            // estaAgarrando=true;
            // anim.SetBool("estaAgarrando",estaAgarrando);
            if (variableDebug == false)
            {
                Searching.SetActive(true);
                Debug.Log("Recogiendo Objeto");
                variableDebug = true;
            }
            if (timerRecoger >= 3f)
            {
                Searching.SetActive(false);
                BigGuy.SetActive(true);
                SonidoFold.SetActive(true);
                Debug.Log("Objeto Grande Recogido");
                timerRecoger = 0f;
                other.transform.gameObject.SetActive(false);
                espacioActual += 3;
                variableDebug = true;
            }
        }
        else
        {
            if (variableDebug == false)
            {
                Searching.SetActive(false);
                SonidoFold.SetActive(false);
                BigGuy.SetActive(false);
                Debug.Log("No puedo Recoger este Objeto");
                variableDebug = true;
            }
        }

        }
    void Deposita()
    {
        if (other.transform.gameObject.tag == "Depositar")
        {
            if (espacioActual > 0)
            {
                Instantiate(YouVeGotSomething);
                Debug.Log("Felicidades!!! Recuperaste Algo!!!");
                espacioActual = 0;
            }
            else
            {
                if (variableDebug == false)
                {
                    Debug.Log("No Tienes Objetos");
                    variableDebug = true;
                }
            }
        }
    }
}
