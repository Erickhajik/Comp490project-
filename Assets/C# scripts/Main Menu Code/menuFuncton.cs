using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menuFuncton : MonoBehaviour
{
    
    
    
     public void GoNameMenu()
    {
        SceneManager.LoadScene("NameMenu");
    }

    public void GoMainMenu()
    {
      
        SceneManager.LoadScene("MainMenu");
    }

    public void GoNewGame()
    {
        SceneManager.LoadScene("Show");
    }

    public void GoOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void GoLeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");
    }
    public void GoCredit()
    {
        SceneManager.LoadScene("Credit");
    }
    public void ExitTheGame()
    {
        Application.Quit();

    }
}
