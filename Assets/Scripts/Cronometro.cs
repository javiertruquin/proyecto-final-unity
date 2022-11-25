using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Cronometro : MonoBehaviour
{
    private int Contador = 61;
    public Text HUD;
    
    // Start is called before the first frame update
    void Start()
    {
    
    }
    private void Awake()
    {
        InvokeRepeating("Segundos", 0f, 1f);
    }
    void Segundos()
    {
        Contador--;
        HUD.text = Contador.ToString();
    }
     
}
