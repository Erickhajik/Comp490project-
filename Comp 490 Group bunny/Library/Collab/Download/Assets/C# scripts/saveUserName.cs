using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveUserName : MonoBehaviour
{
    public Text name;

    private void Update()
    {
       
        name.text= addUserName.userNameSave;
    }
}
