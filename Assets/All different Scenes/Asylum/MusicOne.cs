using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOne : MonoBehaviour
{
    public static AudioSource zombieSound;
    // Start is called before the first frame update
    void Start()
    {
        zombieSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
