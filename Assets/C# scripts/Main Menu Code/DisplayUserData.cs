using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//This scripts,Displays user data in unity Text UI 
//and it uses the Display.php file
public class DisplayUserData : MonoBehaviour
{
    public string[] returnItem;
    //save the string in text UI
    public Text name;
    public Text StartTime;
    public Text Puzzle1Start;
    public Text Puzzle1End;
    public Text Puzzle2Start;
    public Text Puzzle2End;
    public Text Puzzle3Start;
    public Text Puzzle3End;
    public Text EndTime;
    public string[] username;
    public void calllevel1Data()
    {
        StartCoroutine(userData());
    }
       IEnumerator userData()
       {
           WWW www = new WWW("http://3.15.158.50/Display.php");
           yield return www;
           string stringdata = www.text;
           WWW www1 = new WWW("http://3.15.158.50/NumRow.php");
           yield return www1;
           int numberRow=int.Parse(www1.text);
           returnItem = stringdata.Split(';');
       
              for (int i = 0; i < numberRow; i++)
              {
                  if (i == 0)
                  {
                      name.text = getspecificdata(returnItem[i], "Username:");
                      StartTime.text = getspecificdata(returnItem[i], "gamestart:");
                      Puzzle1Start.text=getspecificdata(returnItem[i], "puzzle1start:");
                      Puzzle1End.text=getspecificdata(returnItem[i], "puzzle1end:");
                      Puzzle2Start.text=getspecificdata(returnItem[i], "puzzle2start:");
                      Puzzle2End.text=getspecificdata(returnItem[i], "puzzle2end:");
                      Puzzle3Start.text=getspecificdata(returnItem[i], "puzzle3start:");
                      Puzzle3End.text=getspecificdata(returnItem[i], "puzzle3end:");
                      EndTime.text=getspecificdata(returnItem[i], "endtime:");
                  }
                  else if(i>0)
                  {
                      name.text = name.text + "\n" + getspecificdata(returnItem[i], "Username:");
                      StartTime.text = StartTime.text + "\n" + getspecificdata(returnItem[i], "gamestart:");
                      Puzzle1Start.text = Puzzle1Start.text + "\n" + getspecificdata(returnItem[i], "puzzle1start:");
                      Puzzle1End.text = Puzzle1End.text + "\n" + getspecificdata(returnItem[i], "puzzle1end:");
                      Puzzle2Start.text = Puzzle2Start.text + "\n" + getspecificdata(returnItem[i], "puzzle2start:");
                      Puzzle2End.text = Puzzle2End.text + "\n" + getspecificdata(returnItem[i], "puzzle2end:");
                      Puzzle3Start.text = Puzzle3Start.text + "\n" + getspecificdata(returnItem[i], "puzzle3start:");
                      Puzzle3End.text = Puzzle3End.text + "\n" + getspecificdata(returnItem[i], "puzzle3end:");
                      EndTime.text = EndTime.text + "\n" + getspecificdata(returnItem[i], "endtime:");

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
       