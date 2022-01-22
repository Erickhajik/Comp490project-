using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//To play the same music in all scenes
public class Music : MonoBehaviour
{
    private static Music instance = null;
    public static Music Instance
    {
        get
        {
            return instance;
        }
    }
    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        } else 
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

   
}
 