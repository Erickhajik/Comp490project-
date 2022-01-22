using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clickon : MonoBehaviour
{

    public Animator anim;
    public Key key;

    private void Update()
    {


    }
    private void OnMouseDown()
    {
        Debug.Log("Clicked");
        if (key.key == true)
        {
            Debug.Log("clicked with key");
            anim.SetTrigger("Click");
        }
        
    }



}