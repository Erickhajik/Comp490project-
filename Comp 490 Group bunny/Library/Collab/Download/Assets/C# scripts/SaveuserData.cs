using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveuserData : MonoBehaviour
{
    public string[] returnItem;
    //save the string in text
    public Text name;
    public string[] username;
       IEnumerator Start()
       {
           string m = "-----------------------------------------------------------------------------"; 
           //connect to database
           WWW www = new WWW("http://localhost:8888/first.php");
           yield return www;
           //save the returned text from first.php in a string
           string stringdata = www.text;
           //split the stringdata from where ';' is in the string and put the result in array 
           returnItem = stringdata.Split(';');
           //save the first username and score in the text
           name.text = getspecificdata(returnItem[0], "Username:") + "              " + getspecificdata(returnItem[0], "Score:");
           for(int i=1;i<100;i++)
           {
               name.text = name.text +"\n"+ m+"\n"+ getspecificdata(returnItem[i], "Username:")+"\t\t\t\t\t\t" +getspecificdata(returnItem[0], "Score:");
               
           }
       }
        //function to get the Username and score
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
