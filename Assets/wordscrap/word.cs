using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class word : MonoBehaviour
{
    public Animator an;
   public InputField[] Firstword;
        public InputField[] Secondword;
         public InputField[] Thirdword;
          public InputField[] Fourword;
          public InputField[] Fiveword;
          public string[] FirstW;
          public string[] SecondW;
          public string[] ThirdW;
          public string[] FourW;
          public string[] FiveW;
          public bool finalCheck = true;
          public Camera WordCamera;
          public Camera PlayerCamera;
          public GameObject Player;
          public GameObject WordCanvas;
          public void endGame()
          {
              PlayerCamera.gameObject.SetActive(true);
              Player.SetActive(true);

              WordCamera.gameObject.SetActive(false);
              WordCanvas.SetActive(false);
              Cursor.visible = false;
              Cursor.lockState = CursorLockMode.Locked;
              ZombieFollow.willfollow=true;

             
          }

          void Start()
          {
              an = GetComponent<Animator>();
          }
          void FixedUpdate()
          {
              
          if (checkWord(Firstword, FirstW) && finalCheck && checkWord(Secondword, SecondW)&& checkWord(Thirdword, ThirdW)&& checkWord(Fourword, FourW)&& checkWord(Fiveword, FiveW))
              {
                  finalCheck = false;
                  Level2Puzzle3.StopTimer();
                  Debug.Log(Level2Puzzle3.Level2Puzzle3End);
                 an.Play("end");
              }
          }
          bool checkWord(InputField[] word,string[] w) 
          { 
              int m=0; 
            
              for(int i=0;i<w.Length;i++)
              {
                  if(word[i].text.Equals(w[i])) 
                  {
                      m++;
                   
                  }
              }
              if(m==word.Length)
              {
                  return true;
              }
              return false; 
          }

    
    
}