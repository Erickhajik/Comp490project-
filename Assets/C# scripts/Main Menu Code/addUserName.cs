using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class addUserName : MonoBehaviour
{
    
    
    public InputField playerName;
    public Button submitName;
  
    public static string userNameSave;
   
    public static string Error;
  
    public GameObject DuplicateError;
    public void callAddName()
    {
        StartCoroutine(addName());
    }
    IEnumerator addName()
    {
   
        userNameSave = (playerName.text).ToLower();
        WWWForm form = new WWWForm();
        form.AddField("userName", userNameSave);
        WWW www = new WWW("http://3.14.146.44/AddUserName.php",form);
        yield return www;
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
