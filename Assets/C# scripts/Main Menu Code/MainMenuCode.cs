using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuCode : MonoBehaviour
{
    public InputField userNameSignUp;
    public InputField emailSignUp;
    public InputField confPass;
    public InputField passwordSignup;
    public Animator errorstuff;
    public Button backButtonLogin;
    public Button backButtonSignUp;
    public Text errorText;
    public GameObject LoginPage;
    public GameObject SingUp;
    public GameObject MainLoginSing;
    public GameObject level2Leader;
    public GameObject MainMenu;
    public GameObject level1Leader;
    public GameObject credit;
    public GameObject loadingtwo;
    public GameObject loadingone;
    public GameObject leaderboard;
    public InputField playerName;
    public InputField passwordeq;
    public static string userNameSave;
    private String frsd;
    public static string Error;
    public GameObject DuplicateError;

    void Start()
    {
        errorstuff = gameObject.GetComponent<Animator>();
    }

    public void callAddName()
    {
        StartCoroutine(addName());
    }

    IEnumerator addName()
    {
        userNameSave = playerName.text;
        frsd = passwordeq.text;
       
        WWWForm form = new WWWForm();
        form.AddField("userName", userNameSave);
        form.AddField("pse", frsd);
        if (playerName.text.Length == 0 || passwordeq.text.Length == 0)
        {
            errorstuff.Play("Error");
            errorText.text = "Please fill out all required fields";
        }
        else
        {
            WWW www = new WWW("http://globaltroop.xyz/login.php", form);
            yield return www;
            Error = www.text;

            if (Error == "0")
            {
                loadingtwo.SetActive(true);
                errorstuff.Play("LoginFromLogin");
                 playerName.text = "";
                passwordeq.text = "";
            }
            else
            {
                errorstuff.Play("Error");
                errorText.text = "Invalid username or password";
            }
        }
    }

    public void makeLoginEmpty()
    {
        playerName.text = "";
        passwordeq.text = "";
    }

    public void loginInvalid()
    {
        errorText.text = "Invalid username or password";
    }

    public void filledEmpty()
    {
        errorText.text = "Please fill out all required fields";
    }

    public void userNameExist()
    {
        errorText.text = "Username Already Exist";
    }

    public void emailExist()
    {
        errorText.text = "Email Already Exist";
    }

    public void passwordNoMatch()
    {
        errorText.text = "Passwords don’t match";
    }

    public void enableMain()
    {
        MainMenu.SetActive(true);
    }


    public void disableMain()
    {
        MainMenu.SetActive(false);
    }

    public void enableCredit()
    {
        credit.SetActive(true);
    }


    public void enableLeaderboard()
    {
        leaderboard.SetActive(true);
    }

    public void disableLeaderboard()
    {
        leaderboard.SetActive(false);
    }

    public void disableCredit()
    {
        credit.SetActive(false);
    }

    public void enbaleLoadingtwo()
    {
        loadingtwo.SetActive(true);
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

    public void enableLeaderl()
    {
        level2Leader.SetActive(true);
    }

    public void disableLeaderl()
    {
        level2Leader.SetActive(false);
    }

    public void enableLeader1()
    {
        level1Leader.SetActive(true);
    }

    public void disableLeader1()
    {
        level1Leader.SetActive(false);
    }

    public void enableLoginPage()
    {
        LoginPage.SetActive(true);
    }

    public void disableLoginPage()
    {
        LoginPage.SetActive(false);
    }

    public void enableSignUpPage()
    {
        SingUp.SetActive(true);
    }

    public void disableSignUpPage()
    {
        SingUp.SetActive(false);
    }

    public void enableMainLoginSign()
    {
        MainLoginSing.SetActive(true);
    }

    public void disableMainLoginSign()
    {
        MainLoginSing.SetActive(false);
    }

    public void callSignUp()
    {
        StartCoroutine(signUp());
    }

    IEnumerator signUp()
    {
        userNameSave = userNameSignUp.text;
        WWWForm form = new WWWForm();
        form.AddField("userName", userNameSignUp.text);
        form.AddField("email", emailSignUp.text);
        form.AddField("pass", passwordSignup.text);
        if (confPass.text != passwordSignup.text)
        {
            errorstuff.Play("Error");
            errorText.text = "Passwords don’t match";
        }

        else if (confPass.text.Length == 0 || passwordSignup.text.Length == 0 || userNameSignUp.text.Length == 0 ||
                 emailSignUp.text.Length == 0)
        {
            errorstuff.Play("Error");
            errorText.text = "Please fill out all required fields";
        }
        else
        {



            WWW www = new WWW("http://globaltroop.xyz/SignUp.php", form);
            yield return www;
            Error = www.text;
            if (Error == "0")
            {
                errorstuff.Play("Error");
                errorText.text = "Username Already Exist";
            }
            else if (Error == "1")
            {
                errorstuff.Play("Error");
                errorText.text = "Email Already Exist";
            }
            else
            {

                loadingtwo.SetActive(true);
                errorstuff.Play("SignUpFromSignUp");
                userNameSignUp.text = "";
                emailSignUp.text = "";
                passwordSignup.text = "";
                confPass.text = "";
            }
        }
    }

    public void makeSignUpEmpty()
    {
        userNameSignUp.text = "";
        emailSignUp.text = "";
        passwordSignup.text = "";
        confPass.text = "";
    }

}
