using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; // Blue is waiting
    public GameObject answerAbackGreen; // Green is Correct
    public GameObject answerAbackRed; // Red is wrong

    public GameObject answerBbackBlue; // Blue is waiting
    public GameObject answerBbackGreen; // Green is Correct
    public GameObject answerBbackRed; // Red is wrong

    public GameObject answerCbackBlue; // Blue is waiting
    public GameObject answerCbackGreen; // Green is Correct
    public GameObject answerCbackRed; // Red is wrong

    public GameObject answerDbackBlue; // Blue is waiting
    public GameObject answerDbackGreen; // Green is Correct
    public GameObject answerDbackRed; // Red is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public static Animator anim;
    int numCorrect = 0;
    int numQuestion = 0;

    public GameOver GameOverScene;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void AnswerA()
    {
        if(QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            numCorrect++;
            numQuestion++;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            numQuestion++;
        }
        if(numCorrect == 5)
        {
            GameOverScene.Setup(numCorrect);
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            numCorrect++;
            numQuestion++;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            numQuestion++;
        }
        if (numCorrect == 5)
        {
            GameOverScene.Setup(numCorrect);
           

        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            numCorrect++;
            numQuestion++;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            numQuestion++;
        }
        if (numCorrect == 5)
        {
            GameOverScene.Setup(numCorrect);

        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    public void AnswerD()
    {
        if (QuestionGenerate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            numCorrect++;
            numQuestion++;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            numQuestion++;
        }
        if (numCorrect == 5)
        {
            GameOverScene.Setup(numCorrect);

        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(2);
        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);
        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        QuestionGenerate.displayingQuestion = false;
    }

}
