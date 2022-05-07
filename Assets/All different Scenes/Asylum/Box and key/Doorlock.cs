using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doorlock : MonoBehaviour
{

    public Animator anime;
    public static bool doorlock=false;

    private void OnMouseDown()
    {
        if (doorlock)
        {
            
            anime.SetTrigger("Click");
            Debug.Log("clicked on door");
        }
        
    }



}