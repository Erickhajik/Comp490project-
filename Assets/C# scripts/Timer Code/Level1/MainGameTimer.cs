using System.Collections;
using System.Collections.Generic;
using System.Timers;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainGameTimer : MonoBehaviour
{
    public Text timerText;
    public static float startTime;
    public static bool keepTiming;
    public static float time;
    public static string gameend="";
    public static string gamestart="";
    
    void Start () {
      
    }
    void Update () {
       
        if(keepTiming){
            UpdateTime();
        }
        
    }
    public void UpdateTime(){
        time = Time.time - startTime;
        timerText.text = TimeToString(time);
    }
    public static void StopTimer(){
        keepTiming = false;
        gameend = TimeToString(time);
        time = 0.0f;

    }
    public void ResumeTimer(){
        keepTiming = true;
        startTime = Time.time-time;
    }
    public static void StartTimer(){
        keepTiming = true;
        startTime = Time.time;
        gamestart = TimeToString(time);
    }
    public static string TimeToString(float t){
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f0");
        return minutes + ":" + seconds;
    }
}

