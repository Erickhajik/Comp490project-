using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text pointsText;

    public void Setup()
    {
        gameObject.SetActive(true);
        //pointsText.text = "You got " + score.ToString() + " right";
    }
}
