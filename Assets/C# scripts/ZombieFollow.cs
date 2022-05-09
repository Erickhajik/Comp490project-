using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Windows.Speech;
using UnityEngine.AI;



public class ZombieFollow : MonoBehaviour
{
  public NavMeshAgent enemy;
  public Transform Player;
  private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

  public static bool willfollow=false;
  public float time = 0;
  Vector3 home = new Vector3(-27.30532f,-0.006185174f,-30.09311f);
  

  void Start() {
    actions.Add("Stop", Stop);

            keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
            keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
            keywordRecognizer.Start();
  }

  private void Stop(){
    time=10;
    


  }

  private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
        {
            Debug.Log(speech.text);
            actions[speech.text].Invoke();
        }

  void Update(){

    if (time > 0)
        {
            time -= Time.deltaTime;
            enemy.SetDestination(home);
        }
        else
        {
          if(willfollow)
    {
    enemy.SetDestination(Player.position);

    }
    else
    {
      enemy.SetDestination(home);
    }
        }
        

    
  }
}