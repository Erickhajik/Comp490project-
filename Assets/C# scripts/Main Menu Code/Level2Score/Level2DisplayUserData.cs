using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This scripts,Displays user data in unity Text UI 
//and it uses the Display.php file
public class Level2DisplayUserData : MonoBehaviour
{
    public string[] returnItem;
    //save the string in text UI
    public Text Level2name;
    public Text Level2StartTime;
    public Text Level2Puzzle1Start;
    public Text Level2Puzzle1End;
    public Text Level2Puzzle2Start;
    public Text Level2Puzzle2End;
    public Text Level2Puzzle3Start;
    public Text Level2Puzzle3End;
    public Text Level2EndTime;
    public string[] username;
    public void calllevel2Data()
    {
        StartCoroutine(userData());
    }
       IEnumerator userData()
       {
           WWW www = new WWW("http://globaltroop.xyz/Level2LeaderBoard.php");
           yield return www;
           string stringdata = www.text;
           WWW www1 = new WWW("http://globaltroop.xyz/NumRowLevel2.php");
           yield return www1;
           int numberRow=int.Parse(www1.text);
           returnItem = stringdata.Split(';');
       
              for (int i = 0; i < numberRow; i++)
              {
                  if (i == 0)
                  {
                      Level2name.text = getspecificdata(returnItem[i], "Username:");
                      Level2StartTime.text = getspecificdata(returnItem[i], "gamestart:");
                      Level2Puzzle1Start.text=getspecificdata(returnItem[i], "puzzle1start:");
                      Level2Puzzle1End.text=getspecificdata(returnItem[i], "puzzle1end:");
                      Level2Puzzle2Start.text=getspecificdata(returnItem[i], "puzzle2start:");
                      Level2Puzzle2End.text=getspecificdata(returnItem[i], "puzzle2end:");
                      Level2Puzzle3Start.text=getspecificdata(returnItem[i], "puzzle3start:");
                      Level2Puzzle3End.text=getspecificdata(returnItem[i], "puzzle3end:");
                      Level2EndTime.text=getspecificdata(returnItem[i], "endtime:");
                  }
                  else if(i>0)
                  {
                      Level2name.text = Level2name.text + "\n" + getspecificdata(returnItem[i], "Username:");
                      Level2StartTime.text = Level2StartTime.text + "\n" + getspecificdata(returnItem[i], "gamestart:");
                      Level2Puzzle1Start.text = Level2Puzzle1Start.text + "\n" + getspecificdata(returnItem[i], "puzzle1start:");
                      Level2Puzzle1End.text = Level2Puzzle1End.text + "\n" + getspecificdata(returnItem[i], "puzzle1end:");
                      Level2Puzzle2Start.text = Level2Puzzle2Start.text + "\n" + getspecificdata(returnItem[i], "puzzle2start:");
                      Level2Puzzle2End.text = Level2Puzzle2End.text + "\n" + getspecificdata(returnItem[i], "puzzle2end:");
                      Level2Puzzle3Start.text = Level2Puzzle3Start.text + "\n" + getspecificdata(returnItem[i], "puzzle3start:");
                      Level2Puzzle3End.text = Level2Puzzle3End.text + "\n" + getspecificdata(returnItem[i], "puzzle3end:");
                      Level2EndTime.text = Level2EndTime.text + "\n" + getspecificdata(returnItem[i], "endtime:");

                  }
                  

              }
  
       }
       
        string getspecificdata(string data, string index)
       {
           string value = data.Substring(data.IndexOf(index) + index.Length);
           if (value.Contains("|"))
           {
               value = value.Remove(value.IndexOf("|"));
           }
           
           return value;
       }

       
  }     