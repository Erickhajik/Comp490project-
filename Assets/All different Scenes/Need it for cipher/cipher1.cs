using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cipher1 : MonoBehaviour
{
    //save the player name
    public InputField textinput;
    public Canvas cipherG;
    public Camera cipherCam;
    public Camera MainCamera;
    public static string enteredText;
    public GameObject showError;
    public GameObject help1;
    public GameObject Password;
    
    public GameObject Image;
    private void Start()
    
    {
        Password.SetActive(false);
        help1.SetActive(false);
        showError.SetActive(false);
        Image.SetActive(true);
    }
    

    public void callAddName()
    {
        //save username in lower case
        enteredText = textinput.text;

        

        if (enteredText == "84474747687286697765328")
        {
            Password.SetActive(true);
        }
        else
        {
            textinput.text = "";
            showError.SetActive(true);
        }
    }

    public void quitGame()
    {
        Puzzle1.StopTimer();
        Image.SetActive(false);
        cipherG.gameObject.SetActive(false);
        cipherCam.gameObject.SetActive(false);
        MainCamera.gameObject.SetActive(true);
    }
    
    public void help()
    {
        help1.SetActive(true);
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
   
      
