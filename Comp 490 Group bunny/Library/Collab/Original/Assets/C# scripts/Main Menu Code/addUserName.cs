using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//add name to database
public class addUserName : MonoBehaviour
{
    
    //save the player name
    public InputField playerName;
    public Button submitName;
   //save the user name so ,it can be used later on to save Score in Database,
   //Also being used to display username in MainMenu
    public static string userNameSave;
   //if we get the same name in DB,it saves a 0
   //this is mostly happening in php
    public static string Error;
   //this make it possible to bring up the Error screen
    public GameObject DuplicateError;
    public void callAddName()
    {
        StartCoroutine(addName());
    }
    IEnumerator addName()
    {
        //save username in lower case
        userNameSave = (playerName.text).ToLower();
        WWWForm form = new WWWForm();
        form.AddField("userName", userNameSave);
        WWW www = new WWW("http://localhost:8888/AddUserName.php",form);
        yield return www;
        //save the returned result from php
        Error = www.text;
        if (Error == "0")
        {
            DuplicateError.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
    
}
