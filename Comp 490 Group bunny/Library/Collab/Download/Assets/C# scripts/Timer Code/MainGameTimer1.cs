using System.Collections;
using System.Collections.Generic;
using System.Timers;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainGameTimer1 : MonoBehaviour
{
 
 
    public Text timerText;
    public static float startTime;
    public static bool keepTiming;
   public static float time;
   public bool stoptime;
    public static string gamestart;
    public KeyCode stopTimer;
    public KeyCode startTime1;
    void Start () {
        StartTimer();
      
    }
 
    void Update () {
        if (Input.GetKeyDown(stopTimer))
        {
            keepTiming = false;
            StopTimer();
            SceneManager.LoadSceneAsync("N1");
            Debug.Log("Timer stopped at " + TimeToString(StopTimer()));
        }   
        else if (Input.GetKeyDown(startTime1))
        {
            UpdateTime();
            ResumeTimer();
        }
        if(keepTiming){
            UpdateTime();
        }
        
    }
 
    public void UpdateTime(){
        time = Time.time - startTime;
        timerText.text = TimeToString(time);
    }
 
    public float StopTimer(){
        keepTiming = false;
        return time;
    }
 
   public void ResumeTimer(){
        keepTiming = true;
        startTime = Time.time-time;
    }
    
    public static void StartTimer(){
        keepTiming = true;
        startTime = Time.time;
        gamestart = time.ToString();
    }
 
   public string TimeToString(float t){
        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60 ).ToString("f0");
        return minutes + ":" + seconds;
    }
}

