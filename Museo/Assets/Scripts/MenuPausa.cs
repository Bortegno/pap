using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuDePausa;
    private bool menuOn;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            menuOn = !menuOn;
        }
        if(menuOn==true)
        {
            menuDePausa.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible=true;
            Time.timeScale = 0;
        }
        else
        {
            menuDePausa.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible=false;
            Time.timeScale = 1;
        }
    }
    public void Continuar()
    {
        menuDePausa.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible=false;
        Time.timeScale = 1;
        menuOn=false;
        
    }
    public void Inicio()
    {
        SceneManager.LoadScene(0);
    }

}
