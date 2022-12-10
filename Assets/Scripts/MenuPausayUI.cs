using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausayUI : MonoBehaviour
{
    private bool GameIsPaused ;
    public GameObject MenuP;


    void Update()
    {
        TogglePausa();
    }
    public void TogglePausa() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {if (GameIsPaused)
                PausaOff();
            else
                PausaOn();
                               
        }
        }
    public void PausaOn()
    {
        MenuP.SetActive(true);
        GameIsPaused = true;
        Time.timeScale = 0;
    }

    public void PausaOff()
    {
        MenuP.SetActive(false);
        GameIsPaused = false;
        Time.timeScale = 1;
    }
}
