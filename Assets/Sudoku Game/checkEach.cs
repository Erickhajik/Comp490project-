using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class checkEach : MonoBehaviour
{

    public Camera sudokuCam;
    public Canvas sudokustuff;
    public Camera gameCam;
    public GameObject gameCanvas;
    public Animator k;
    public Text timeAdd;
    public static string[] timesadd={"+10s","+20s","+30s"};
    public static int Hintnum=0;
  public String[] hintUsed;
  public static int timeToAdd;
  public GameObject ScaryAnim;
  public InputField[] A;
  public int[] Afill;
  public InputField[] B;
  public int[] Bfill;
  public InputField[] C;
      public int[] Cfill;
      public InputField[] D;
      public int[] Dfill;
      public InputField[] E;
      public int[] Efill;
      public InputField[] F;
      public int[] Ffill;
      public InputField[] G;
      public int[] Gfill;
      public InputField[] H;
      public int[] Hfill;
      public InputField[] I;
      public int[] Ifill;
      public Text HintShow;
      public bool starting = true;
      void Start ()
  {
      k = gameObject.GetComponent<Animator>();
      Cursor.visible = true;
      Cursor.lockState = CursorLockMode.None;
      
      // GameTime.StartTimer();
      // CheckUsed.text = checkUsd.ToString();
  }
    void Update()
    {
        checkWrong();
        HintShow.text = Hintnum.ToString();
        if (checkA(A, Afill) && checkA(B, Bfill) && checkA(C, Cfill) &&
            checkA(D, Dfill) && checkA(E, Efill) && checkA(F, Ffill) &&
            checkA(G, Gfill) && checkA(H, Hfill) && checkA(I, Ifill) && starting)
        {
            starting = false;
            GameTime.StopTimer();
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            k.Play("SudokuFinal");
        }
    }
    public void gameEnd()
    {
        gameCam.gameObject.SetActive(true);
        gameCanvas.SetActive(true);
    sudokuCam.gameObject.SetActive(false);
    sudokustuff.gameObject.SetActive(false);
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    }
    public void disable()
    {
        ScaryAnim.SetActive(false);
        // k.Play("New State 0");
    }
    public void PlaytheScary()
    {
        int randomInt = Random.Range(0, 3);
        if (randomInt == 0)
        {
            timeAdd.text = timesadd[0];
            timeToAdd = 10;
        }
        else if (randomInt == 1)
        {
            timeAdd.text = timesadd[1];
            timeToAdd = 20;
        }
        else if (randomInt == 2)
        {
            timeAdd.text = timesadd[2];
            timeToAdd = 30;
        }
        ScaryAnim.SetActive(true);
        k.Play(hintUsed[0]);
    }
    public void GetRandom()
   {
       int randomHint = 0;
        int randomInt = Random.Range(0, 9);
        Debug.Log(randomHint);
        if (randomInt == 0)
        { 
            randomHint=Random.Range(0, A.Length);
            if (A[randomHint].text == "")
            {
                Hintnum++;
                A[randomHint].text = Afill[randomHint].ToString();
                A[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 1)
        {
            randomHint = Random.Range(0, B.Length);
            if (B[randomHint].text == "")
            {
                Hintnum++;              
                B[randomHint].text = Bfill[randomHint].ToString();
                B[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 2)
        {
            randomHint = Random.Range(0, C.Length);
            if (C[randomHint].text == "")
            {
                Hintnum++;
                C[randomHint].text = Cfill[randomHint].ToString();
                C[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 3)
        {
            randomHint = Random.Range(0, D.Length);
            if (D[randomHint].text == "")
            {
                Hintnum++;
                D[randomHint].text = Dfill[randomHint].ToString();
                D[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 4)
        {
             randomHint = Random.Range(0, E.Length);
            if (E[randomHint].text == "")
            {
                Hintnum++;
                E[randomHint].text = Efill[randomHint].ToString();
                E[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 5)
        {
            randomHint = Random.Range(0, F.Length);
            if (F[randomHint].text == "")
            {
                Hintnum++;
                F[randomHint].text = Ffill[randomHint].ToString();
                F[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 6)
        {
            randomHint = Random.Range(0, G.Length);
            if (G[randomHint].text == "")
            {
                Hintnum++;
                G[randomHint].text = Gfill[randomHint].ToString();
                G[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 7)
        {
            randomHint = Random.Range(0, H.Length);
            if (H[randomHint].text == "")
            {
                Hintnum++;
                H[randomHint].text = Hfill[randomHint].ToString();
                H[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }
        else if (randomInt == 8)
        {
            randomHint = Random.Range(0, I.Length);
            if (I[randomHint].text == "")
            {
                Hintnum++;
                I[randomHint].text = Ifill[randomHint].ToString();
                I[randomHint].DeactivateInputField();
            }
            else
            {
                GetRandom();
            }
        }

        PlaytheScary();
   }
    bool checkA(InputField[] A,int[] Afill)
    {
        int n = 0;
        for (int i = 0; i < A.Length; i++)
        {
            
            if (A[i].text == Afill[i].ToString())
            {
               
                n++;
            }

        }

        if (n == A.Length)
        {
            return true;
        }
            return false;
        }
 

    public void checkWrong()
    {

        checkAWrong(A,Afill);
        checkAWrong(B,Bfill);
        checkAWrong(C,Cfill);
        checkAWrong(D,Dfill);
        checkAWrong(E,Efill);
        checkAWrong(F,Ffill);
        checkAWrong(G,Gfill);
        checkAWrong(H,Hfill);
        checkAWrong(I,Ifill);
    }
    
    void checkAWrong(InputField[] A,int[] Afill)
    {
       
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i].text != "")
            {
                // Awrong[i] = 0;
                if (A[i].text != Afill[i].ToString())
                {
                  
                     
                            A[i].image.color = Color.red;
                            
                        }
                       
                    
                    else
                    {
                        A[i].image.color = Color.white;

                    }
                }
            else if (A[i].text == "" && A[i].image.color == Color.red)
            {
                A[i].image.color = Color.white;
            }
            
        }
    }
    
    
}

