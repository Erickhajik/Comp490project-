using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doorlock : MonoBehaviour
{

    public Animator anim;
    public static bool doorlock=false;

    private void OnMouseDown()
    {
        if (doorlock)
        {
            
            anim.SetTrigger("Click");
            Debug.Log("clicked on door");
        }
        
    }



}