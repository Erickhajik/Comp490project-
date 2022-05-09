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
      public GameObject playerCamra;
      public GameObject gameCamra;
      public GameObject playerCan;
      public GameObject gameCan;
      public void close()
      {
          playerCamra.SetActive(true);
          playerCan.SetActive(true);
          gameCamra.SetActive(false);
          gameCan.SetActive(false);
          Cursor.lockState = CursorLockMode.Locked;
          Cursor.visible = false;
         ZombieFollow.willfollow=true;
      }
      void Start()
      {
          k = gameObject.GetComponent<Animator>(); ;
      }
      void Update()
    {
        checkWrong();
        if (Input.GetKeyDown(KeyCode.I))
        {
            Level2Puzzle1.StopTimer();
            Debug.Log(Level2Puzzle1.Level2puzzle1End);
            k.Play("final");
        }
        HintShow.text = Hintnum.ToString();
        if (check(A, Afill) && check(B, Bfill) && check(C, Cfill) &&
            check(D, Dfill) && check(E, Efill) && check(F, Ffill) &&
            check(G, Gfill) && check(H, Hfill) && check(I, Ifill) && starting)
        {
            starting = false;
            Level2Puzzle1.StopTimer();
            Debug.Log(Level2Puzzle1.Level2puzzle1End);
            k.Play("final");
        }
    }
      public void disable()
      {
        ScaryAnim.SetActive(false);
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
            randomHint1(A, Afill, randomHint);
        }
        else if (randomInt == 1)
        {
            randomHint1(B, Bfill, randomHint);
        }
        else if (randomInt == 2)
        {
            randomHint1(C, Cfill, randomHint);
        }
        else if (randomInt == 3)
        {
            randomHint1(D, Dfill, randomHint);
        }
        else if (randomInt == 4)
        {
            randomHint1(E, Efill, randomHint);
        }
        else if (randomInt == 5)
        {
            randomHint1(F, Ffill, randomHint);
        }
        else if (randomInt == 6)
        {
            randomHint1(G, Gfill, randomHint);
        }
        else if (randomInt == 7)
        {
            randomHint1(H, Hfill, randomHint);
        }
        else if (randomInt == 8)
        {
            randomHint1(I, Ifill, randomHint);
        }
        PlaytheScary();
   }
    void randomHint1(InputField [] I,int [] Ifill,int randomHint)
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
    bool check(InputField[] A,int[] Afill)
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
        checkWrong(A,Afill);
        checkWrong(B,Bfill);
        checkWrong(C,Cfill);
        checkWrong(D,Dfill);
        checkWrong(E,Efill);
        checkWrong(F,Ffill);
        checkWrong(G,Gfill);
        checkWrong(H,Hfill);
        checkWrong(I,Ifill);
    }
    void checkWrong(InputField[] A,int[] Afill)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i].text != "")
            {
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

