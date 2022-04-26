using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevel2 : MonoBehaviour
{

    private void OnMouseDown()
    {
       
        SceneManager.LoadScene("Level2");
    }
}
