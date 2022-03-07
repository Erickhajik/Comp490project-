using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class addUserName : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credit;
    public GameObject option;
    public GameObject loadingtwo;
    public GameObject loadingone;
    public GameObject leaderboard;
    public GameObject Login;
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
        WWW www = new WWW("http://localhost/AddUserName.php",form);
        yield return www;
        Error = www.text;
        
        if (Error == "0")
        {
            DuplicateError.SetActive(true);
        }
        // else
        // {
        //     SceneManager.LoadScene("MainMenu");
        // }
    }


    public void enableMain()
    {
        mainMenu.SetActive(true);
    }
    public void enableCredit()
    {
        credit.SetActive(true);
    }
    public void disableMain()
    {
        mainMenu.SetActive(false);
    }
     public void enableOption()
     {
         option.SetActive(true);
     }
     public void enableLeaderboard()
     {
         leaderboard.SetActive(true);
     }
     public void disableLeaderboard()
     { 
         leaderboard.SetActive(false);
     }
     public void disableOption()
     { 
         option.SetActive(false);
     }
     public void disableCredit()
     { 
         credit.SetActive(false);
     }
     public void disableLoadingtwo()
     { 
         loadingtwo.SetActive(false);
     }
     public void disableLoadingone()
     { 
         loadingone.SetActive(false);
     }
     public void enableLoadingone()
     { 
         loadingone.SetActive(true);
     }
    
     public void enableLogin()
     { 
         Login.SetActive(true);
     }

}
