using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text pointsText;
    public GameObject final;
    public  Animator anim;



    void Start()
    {
        anim = GetComponent<Animator>();
        // GetComponent<>()
    }
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        final.SetActive(true);
        pointsText.text = "You got " + score.ToString() + " right";
        anim.Play("finalpass");
    }
}
