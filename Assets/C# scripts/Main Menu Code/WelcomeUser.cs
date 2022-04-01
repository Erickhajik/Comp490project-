using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WelcomeUser : MonoBehaviour
{
    public Text name;

    private void Update()
    {
        name.text= "Welocme "+MainMenuCode.userNameSave;
    }
}
