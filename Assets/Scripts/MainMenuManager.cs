using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSecondLevel()
    {
            SceneManager.LoadScene(2);
    }

    public void LoadThirdLevel()
    {
            SceneManager.LoadScene(3);
    }

    public void LoadFourthLevel()
    {
            SceneManager.LoadScene(4);
    }

    public void LoadFifthLevel()
    {
            SceneManager.LoadScene(5);
    }

    public void LoadSixthLevel()
    {
            SceneManager.LoadScene(6);
    }
    

    public void QuitGame()
    {
        //ovo radi samo u bildu
        Application.Quit();
    }
}
