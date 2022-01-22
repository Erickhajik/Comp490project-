using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenetoLevel1 : MonoBehaviour
{

    private void OnMouseDown()
    {
        // MainGameTimer.time= Time.time;
        MainGameTimer.StartTimer();
        SceneManager.LoadScene("Level 1");
    }
}
