using System.Collections;
using System.Collections.Generic;
using System.Timers;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Level2MainTimer : MonoBehaviour
{
    public Text timerText;
    public static float startTime;
    public static bool keepTiming;
    public static float time;
    public static string Level2gameend="";
    public static string Level2gamestart="";
    private static int[] times = {5, 10, 15, 20,25,30,35,40};
    public static float time1;
    void Start () {
      
    }
    void Update ()
    {
        time1 = Time.time;
        if(keepTiming){
            UpdateTime();
        }
        
    }

    public static void addTime()
    {
        keepTiming = false;
        time1 = time;
        int a = Random.Range(0, 7);
        time1 = time1 + times[a];
        startTime = Time.time -time1;
        keepTiming = true;
    }
    public void UpdateTime(){
        time = Time.time - startTime;
        timerText.text = TimeToString(time);
    }
    public static void StopTimer(){
        keepTiming = false;
        Level2gameend = TimeToString(time);
        Level2gamestart = "0:0";
       Debug.Log(Level2gameend);
    }
    public void ResumeTimer(){
        keepTiming = true;
        startTime = Time.time-time;
    }
    public static void StartTimer(){
        keepTiming = true;
        startTime = Time.time;
        Level2gamestart = TimeToString(time);
        
    }
    public static string TimeToString(float t){
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f0");
        return minutes + ":" + seconds;
    }
}

