using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class word : MonoBehaviour
{
    // Start is called before the first frame update
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

          void FixedUpdate()
          {
              if (checkWord(Firstword, FirstW) && finalCheck && checkWord(Secondword, SecondW)&& checkWord(Thirdword, ThirdW)&& checkWord(Fourword, FourW)&& checkWord(Fiveword, FiveW))
              {
                  finalCheck = false;
                  Debug.Log("Done");
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