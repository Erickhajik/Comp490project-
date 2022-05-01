using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level2Puzzle1 : MonoBehaviour
{
 
 
    public Text timerText;
    private static float startTime;
    static bool keepTiming;
    static float time;
    private bool stoptime;
    public static string Level2puzzle1Start="";
    public static string Level2puzzle1End="";
    public static float time13;
    //Needs to be changed to whatever we press to start the game
    
    
    
    void Start () {
        StartTimer();
    }
 
    void Update () {
        
        if(keepTiming){
            UpdateTime();
        }
        
    }
    public void addTime()
    {
        keepTiming = true;
        time13=time13 + checkEach.timeToAdd;
        startTime = Time.time-time13;
    }
    void UpdateTime(){
        time = Time.time - startTime;
        timerText.text = TimeToString(time);
    }
 
    public static void StopTimer(){
        keepTiming = false;
        Level2puzzle1End = TimeToString(time);
        // Debug.Log(Level2puzzle1End);
      
    }
 
    void ResumeTimer(){
        keepTiming = true;
        startTime = Time.time-time;
    }
    
    public static void StartTimer(){
        keepTiming = true;
        startTime = Time.time;
        Level2puzzle1Start = TimeToString(time);
    }

   public static string TimeToString(float t){
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f0");
        return minutes + ":" + seconds;
    }
}

