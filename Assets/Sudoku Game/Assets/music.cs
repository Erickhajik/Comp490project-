using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    
    public AudioSource mSecond;
    public AudioSource mFirst;
    public AudioClip[] playlist;
    void Start()
    {
        // playlist1[2].
        mFirst = gameObject.GetComponent<AudioSource>();
        mSecond = gameObject.GetComponent<AudioSource>();

    }

   

    public void playsecond()
    {
       
            mSecond.clip = playlist[0];
            mSecond.Play();
            
        
       
    }
    
    public void playfirst()
    {
       
        mFirst.clip = playlist[1];
        mFirst.Play();
            
        
       
    }
    
    public void stopPlay()
    {
        if (mSecond.isPlaying)
        {
           
            mSecond.Stop();
        }
       
    }
    public void stopPlaysecond()
    {
        if (mFirst.isPlaying)
        {
           
            mFirst.Stop();
        }
       
    }
}