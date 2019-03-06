using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenuManager : MonoBehaviour
{
    int lvlnum = 0;
    const string filename = "SaveFile.dat";

    private void Awake()
    {
        get_level_number();
    }

    public void get_level_number()
    {
        if(File.Exists(filename))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                lvlnum = reader.ReadInt32();
            }
        }
    }

    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSecondLevel()
    {
        if (lvlnum > 0)
            SceneManager.LoadScene(2);
    }

    public void LoadThirdLevel()
    {
        if (lvlnum > 1)
            SceneManager.LoadScene(3);
    }

    public void LoadFourthLevel()
    {
        if (lvlnum > 2)
            SceneManager.LoadScene(4);
    }

    public void LoadFifthLevel()
    {
        if (lvlnum > 3)
            SceneManager.LoadScene(5);
    }

    public void LoadSixthLevel()
    {
        if (lvlnum > 4)
            SceneManager.LoadScene(6);
    }
    

    public void QuitGame()
    {
        //ovo radi samo u bildu
        Application.Quit();
    }
}
