using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level2Puzzle3 : MonoBehaviour
{

    public Text timerText;
    private static float startTime;
    static bool keepTiming;
    static float time;
    private bool stoptime;
    public static string Level2Puzzle3Start="";
    public static string Level2Puzzle3End="";
    
   
    void Start () {
        StartTimer();
    }
 
    void Update () {
        
       
        if(keepTiming){
            UpdateTime();
        }
        
    }
 
    void UpdateTime(){
        time = Time.time - startTime;
        timerText.text = TimeToString(time);
    }
 
    public static void StopTimer(){
        keepTiming = false;
        Level2Puzzle3End = TimeToString(time);
        time = 0.0f;
       
    }
 
    void ResumeTimer(){
        keepTiming = true;
        startTime = Time.time-time;
    }
    
    public static void StartTimer(){
        keepTiming = true;
        startTime = Time.time;
        Level2Puzzle3Start = TimeToString(time);
    }

    static string TimeToString(float t){
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f0");
        return minutes + ":" + seconds;
    }
}

