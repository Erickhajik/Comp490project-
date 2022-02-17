using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;

public class VoiceAccept : MonoBehaviour
{

    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    private void Start()
    {
        actions.Add("pumpkin", EndGame);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();
    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }
    private void EndGame()
    {

    }
    
}