using System.Collections;
using System.Collections.Generic;
using System.Timers;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameTime : MonoBehaviour
{
    public Text timeTe;
    public static float startTime;
    public static bool keepTiming;
    public static float time;
    public static string gameend="";
    public static string gamestart="";
    public static float time13;
    void Start () {
      
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
        timeTe.text = TimeToString(time);
    }
    public static void StopTimer(){
        keepTiming = false;
        gameend = TimeToString(time);
        time = 0.0f;

    }

   
    public void stopT()
    {
        keepTiming = false;
        time13 = time;
    }
    // public static void ResumeTimer(){
    //     keepTiming = true;
    //     
    //     startTime = Time.time-time13;
    // }
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

