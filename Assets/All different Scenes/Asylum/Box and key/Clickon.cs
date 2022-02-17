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
        if (key.key == true)
        {
            anim.SetTrigger("Click");
            Debug.Log("clicked on door");
        }
        
    }



}