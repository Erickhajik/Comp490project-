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
      
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            
        }
    }
    public void Setup(int score)
    {
        Level2Puzzle2.StopTimer();
        Debug.Log(Level2Puzzle2.Level2puzzle2End);
        gameObject.SetActive(true);
        final.SetActive(true);
        pointsText.text = "You got " + score.ToString() + " right";
        anim.Play("finalpass");
    }
    
}
