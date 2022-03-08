using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class menuFuncton : MonoBehaviour
{
    public void ExitTheGame()
    {
        Application.Quit();

    }

    public void loadLobby()
    {
        SceneManager.LoadScene("Show");
    }
}
