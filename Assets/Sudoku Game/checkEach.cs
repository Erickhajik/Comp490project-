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
      // public int checkUsd=0;
      public Text HintShow;
      // public Text CheckUsed;

      // public GameObject disableFirst;
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
       
        if (checkA(A, Afill) && checkB(B, Bfill) && checkC(C, Cfill) &&
            checkD(D, Dfill) && checkE(E, Efill) && checkF(F, Ffill) &&
            checkG(G, Gfill) && checkH(H, Hfill) && checkI(I, Ifill) && starting)

        {
            starting = false;
            Level2Puzzle1.StopTimer();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
       
        
        

        
    }
    
    //Hint Animation

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
    bool checkB(InputField[] B,int[] Bfill)
    {
        int n = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i].text == Bfill[i].ToString())
            {
                n++;
            }
        }

        if (n == B.Length)
        {
            return true;
        }
        return false;
    }
    bool checkC(InputField[] C,int[] Cfill)
    {
        int n = 0;
        for (int i = 0; i < C.Length; i++)
        {
            if (C[i].text == Cfill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == C.Length)
        {
            return true;
        }
        return false;
    }
    bool checkD(InputField[] D,int[] Dfill)
    {
        int n = 0;
        for (int i = 0; i < D.Length; i++)
        {
            if (D[i].text == Dfill[i].ToString())
            {
                n++;
            }
           
        }

        if (n == D.Length)
        {
            return true;
        }
        return false;
    }
    bool checkE(InputField[] E,int[] Efill)
    {
        int n = 0;
        for (int i = 0; i < E.Length; i++)
        {
            if (E[i].text == Efill[i].ToString())
            {
                n++;
            }
           
        }

        if (n == E.Length)
        {
            return true;
        }
        return false;
    }
    bool checkF(InputField[] F,int[] Ffill)
    {
        int n = 0;
        for (int i = 0; i < F.Length; i++)
        {
            if (F[i].text == Ffill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == F.Length)
        {
            return true;
        }
        return false;
    }
    bool checkG(InputField[] G,int[] Gfill)
    {
        int n = 0;
        for (int i = 0; i < G.Length; i++)
        {
            if (G[i].text == Gfill[i].ToString())
            {
                n++;
            }
            
        }
        if (n == G.Length)
        {
            return true;
        }
        return false;
    }
    bool checkH(InputField[] H,int[] Hfill)
    {
        int n = 0;
        for (int i = 0; i < H.Length; i++)
        {
            if (H[i].text == Hfill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == H.Length)
        {
            return true;
        }
        return false;
    }
    bool checkI(InputField[] I,int[] Ifill)
    {
        int n = 0;
        for (int i = 0; i < I.Length; i++)
        {
            if (I[i].text == Ifill[i].ToString())
            {
                n++;
            }
            
            
        }

        if (n == I.Length)
        {
            return true;
        }
        return false;
    }

    public void checkWrong()
    {

        checkAWrong(A,Afill);
        checkBWrong(B,Bfill);
        checkCWrong(C,Cfill);
        checkDWrong(D,Dfill);
        checkEWrong(E,Efill);
        checkFWrong(F,Ffill);
        checkGWrong(G,Gfill);
        checkHWrong(H,Hfill);
        checkIWrong(I,Ifill);
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
    void checkBWrong(InputField[] B,int[] Bfill)
    {
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i].text != "")
            {
                if (B[i].text != Bfill[i].ToString())
                {
                   

                    B[i].image.color = Color.red;
                }
                else
                {
                    B[i].image.color = Color.white;

                }
            }
            else if (B[i].text == "" && B[i].image.color == Color.red)
            {
                B[i].image.color = Color.white;
            }
        }
    }
    void checkCWrong(InputField[] C,int[] Cfill)
    {
        
        for (int i = 0; i < C.Length; i++)
        {
            if (C[i].text != "")
            {
                if (C[i].text != Cfill[i].ToString())
                {
                    

                    C[i].image.color = Color.red;
                }
                else
                {
                    C[i].image.color = Color.white;

                }
            }
            else if (C[i].text == "" && C[i].image.color == Color.red)
            {
                C[i].image.color = Color.white;
            }
        }
    }
    void checkDWrong(InputField[] D,int[] Dfill)
    {
        for (int i = 0; i < D.Length; i++)
        {
            if (D[i].text != "")
            {
                if (D[i].text != Dfill[i].ToString())
                {
                   

                    D[i].image.color = Color.red;
                }
                else
                {
                    D[i].image.color = Color.white;

                }
            }
            else if (D[i].text == "" && D[i].image.color == Color.red)
            {
                D[i].image.color = Color.white;
            }
        }
    }
    void checkEWrong(InputField[] E,int[] Efill)
    {
        for (int i = 0; i < E.Length; i++)
        {
            if (E[i].text != "")
            {
                if (E[i].text != Efill[i].ToString())
                {
                   

                    E[i].image.color = Color.red;
                }
                else
                {
                    E[i].image.color = Color.white;

                }
            }
            else if (E[i].text == "" && E[i].image.color == Color.red)
            {
                E[i].image.color = Color.white;
            }
        }
    }
    void checkFWrong(InputField[] F,int[] Ffill)
    {
        for (int i = 0; i < F.Length; i++)
        {
            if (F[i].text != "")
            {
                if (F[i].text != Ffill[i].ToString())
                {
                   

                    F[i].image.color = Color.red;
                }
                else
                {
                    F[i].image.color = Color.white;

                }
            }
            else if (F[i].text == "" && F[i].image.color == Color.red)
            {
                F[i].image.color = Color.white;
            }
        }
    }
    void checkGWrong(InputField[] G,int[] Gfill)
    {
        for (int i = 0; i < G.Length; i++)
        {
            if (G[i].text != "")
            {
                if (G[i].text != Gfill[i].ToString())
                {
                   

                    G[i].image.color = Color.red;
                }
                else
                {
                    G[i].image.color = Color.white;

                }
            }
            else if (G[i].text == "" && G[i].image.color == Color.red)
            {
                G[i].image.color = Color.white;
            }
        }
    }
    void checkHWrong(InputField[] H,int[] Hfill)
    {
        for (int i = 0; i < H.Length; i++)
        {
            if (H[i].text != "")
            {
                if (H[i].text != Hfill[i].ToString())
                {
                   

                    H[i].image.color = Color.red;
                }
                else
                {
                    H[i].image.color = Color.white;

                }
            }
            else if (H[i].text == "" && H[i].image.color == Color.red)
            {
                H[i].image.color = Color.white;
            }
        }
    }
    void checkIWrong(InputField[] I,int[] Ifill)
    {
        for (int i = 0; i < I.Length; i++)
        {
            if (I[i].text != "")
            {
                if (I[i].text != Ifill[i].ToString())
                {
                  

                    I[i].image.color = Color.red;
                }
                else
                {
                    I[i].image.color = Color.white;

                }
            }
            else if (I[i].text == "" && I[i].image.color == Color.red)
            {
                I[i].image.color = Color.white;
                
            }
        }
    }
    
}

