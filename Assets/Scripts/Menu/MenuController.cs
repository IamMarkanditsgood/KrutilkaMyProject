using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PressPlay()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void PressExit()
    {
        Application.Quit();
    }
    public void PressSettings()
    {

    }
}
