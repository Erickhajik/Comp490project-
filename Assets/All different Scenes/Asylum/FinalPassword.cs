using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;

public class FinalPassword : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
        public Button enter;
    
        public InputField textinput;
        public GameObject congratulation;
        public Text timeTake;
        public static string enteredText;
       
        public void checkName()
        {
          
            enteredText = textinput.text;
            
            if (enteredText == "pumpkin")
            {
                EndGame();
              
            }
            else
            {
                textinput.text = "";
            }
        }
        private void Start()
        {
            actions.Add("pumkin", EndGame);

            keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
            keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
            keywordRecognizer.Start();
        }
        void Update()
        {
            
        }

        public void ValueChangeCheck()
        {
            if (textinput.text.Length == 4)
            {

                textinput.text += "\n";
            }  
        }
        private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
        {
            Debug.Log(speech.text);
            actions[speech.text].Invoke();
        }
        private void EndGame()
        {
            Level2MainTimer.StopTimer();
            congratulation.SetActive(true);
            timeTake.text = "You have Completed the Level 1 " + MainGameTimer.gameend;
        }

        public void addQ()
        {
            textinput.text +="q";
        }
        public void addW()
        {
            textinput.text +="w";
        }
        public void addE()
        {
            textinput.text +="e"; 
        }
        public void addR()
        {
            textinput.text +="r";
        }
        public void addT()
        {
            textinput.text +="t";
        }
        public void addY()
        {
            textinput.text +="y";
        }
        public void addU()
        {
            textinput.text +="u";
        }
        public void addI()
        {
            textinput.text +="i"; 
        }
        public void addO()
        {
            textinput.text +="o";
        }
        public void addP()
        {
            textinput.text +="p";
        }
        public void addspecial1()
        {
            textinput.text +="["; 
        }

        public void addspecial2()
        {
            textinput.text += "]";
        }

        public void addA()
        {
            textinput.text +="a";
        }
        public void addS()
        {
            textinput.text +="s";
        }
        public void addD()
        {
            textinput.text +="d";  
        }
        public void addF()
        {
            textinput.text +="f"; 
        }
        public void addG()
        {
            textinput.text +="g"; 
        }
        public void addH()
        {
            textinput.text +="h";
        }
        public void addJ()
        {
            textinput.text +="j"; 
        }
        public void addK()
        {
            textinput.text +="k"; 
        }
        public void addL()
        {
            textinput.text +="l";
        }
        public void addspecial4()
        {
            textinput.text +=";"; 
        }
        public void addspecial5()
        {
            textinput.text +="'"; 
        }
        public void addZ()
        {
            textinput.text +="z";  
        }
        public void addX()
        {
            textinput.text +="x";  
        }
        public void addC()
        {
            textinput.text +="c"; 
        }
        public void addV()
        {
            textinput.text +="v";  
        }
        public void addB()
        {
            textinput.text +="b"; 
        }
        public void addN()
        {
            textinput.text +="n"; 
        }
        public void addM()
        {
            textinput.text +="m";
        }
        public void addspecial6()
        {
            textinput.text +=","; 
        }
        public void addspecial7()
        {
            textinput.text +="."; 
        }
        public void addspecial8()
        {
            textinput.text +="/"; 
        }
        public void addspace()
        {
            textinput.text +=" ";  
        }
        public void addremove()
        {
            textinput.text.Remove(textinput.text.Length - 1);
           
        }
        public void quitToGame()
        {
            SceneManager.LoadScene("NameMenu");
        }


        
}


