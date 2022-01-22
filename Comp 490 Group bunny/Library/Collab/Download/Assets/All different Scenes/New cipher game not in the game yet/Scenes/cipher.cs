using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cipher : MonoBehaviour
{
    //save the player name
    
    public Canvas cipherG;
    public Camera cipherCam;
    public Camera MainCamera;
    public GameObject Password;
  
    public InputField textinput;
    public Button submitbutton;
   
    public static string enteredText;
    public GameObject showError;
    public GameObject help1;
    public Text word;
     string translateword="lfnnk";
     string alphabetsed="wlugcrxsqdvbonypimztfhajke";
     private string alphabetOriginal = "abcdefghijklmnopqrstuvwxyz";
     public Text alphabetUsed;
    public Text hint;
    public Text showThe;
    public float timeReamin = 180;
    public Text helptext;
    public Button helpbutton;
     public Text HelpTextDisplay;
    private void Start()
    {
        HelpTextDisplay.gameObject.SetActive(false);
        helpbutton.enabled=false;
        char[] alp = alphabetOriginal.ToCharArray();
        char[] alpa = alphabetsed.ToCharArray();
        showThe.gameObject.SetActive(false);
        hint.gameObject.SetActive(false);
        help1.SetActive(false);
        showError.SetActive(false);
        word.text="Translate this word\n" + translateword;
        alphabetUsed.text = "Using this alphabet\n"+alphabetsed;
        
        for (int i = 0; i < alpa.Length; i++)
        {
            hint.text= hint.text+(i+1)+") "+alpa[i]+" = "+alp[i]+" ";
        }
       
        Password.SetActive(false);
    }

   
    
    public void Update()
    {
        if (timeReamin > 1)
        {
            timeReamin -= Time.deltaTime;
           DisplayTime(timeReamin);
           // if(timeReamin==0)
           // {
           //     HelpTextDisplay.gameObject.SetActive(true);
           //     helptext.gameObject.SetActive(false);
           //     helpbutton.enabled = true;
           // }
        }
        else 
        {
           
            HelpTextDisplay.gameObject.SetActive(true);
            helptext.gameObject.SetActive(false);
            helpbutton.enabled = true;
            helpbutton.onClick.AddListener(() => StartTime());
            {
                
            }
        }
    }
    public void quitGame()
    {
        Puzzle1.StopTimer();
        cipherG.gameObject.SetActive(false);
        cipherCam.gameObject.SetActive(false);
        MainCamera.gameObject.SetActive(true);
    }
    void StartTime()
    {
        float time = 180;
        HelpTextDisplay.gameObject.SetActive(false);   
        time -= Time.deltaTime;
        DisplayTime(timeReamin);
    }
    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);  
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        helptext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    public void callAddName()
    {
        //save username in lower case
        enteredText = textinput.text;
        if (enteredText == "28669")
            {
                Password.SetActive(true);
                
            }
            else
            {
                textinput.text = "";
                showError.SetActive(true);
            }
        
       
    }

    public void help()
    {
        help1.SetActive(true);
        hint.gameObject.SetActive(true);



    }
//23
    // public void check()
    // {
    //     showThe.gameObject.SetActive(true);
    //     string code = "84474747687286697765328";
    //     char[] codechar = code.ToCharArray();
    //     string Tocheck = textinput.text;
    //     char[] checking = Tocheck.ToCharArray();
    //     for (int i = 0; i < checking.Length; i++)
    //     {
    //         if (checking.Length == 23)
    //         {
    //             if (codechar[i] == checking[i])
    //             {
    //                 showThe.text += codechar[i];
    //             }
    //             else if (codechar[i] != checking[i])
    //             {
    //                 showThe.text = showThe.text + "*";
    //             }
    //         }
    //         else
    //         {
    //             //sh
    //         }
    //     }
    // }
    public void clear()
    {
        
        textinput.text = ""; 
    }
    public void addOne()
    {
        textinput.text = textinput.text + "1";
    }
    public void addTwo()
    {
        textinput.text = textinput.text + "2";
    }
    public void addThree()
    {
        textinput.text = textinput.text + "3";
    }
    public void addFour()
    {
        textinput.text = textinput.text + "4";
    }
    public void addFive()
    {
        textinput.text = textinput.text + "5";
    }
    public void addSix()
    {
        textinput.text = textinput.text + "6";
    }
    public void addSeven()
    {
        textinput.text = textinput.text + "7";
    }
    public void addEight()
    {
        textinput.text = textinput.text + "8";
    }
    public void addNine()
    {
        textinput.text = textinput.text + "9";
    }

}
   
      
