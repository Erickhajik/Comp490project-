using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{

    public Animator anim;

    private void OnMouseDown()
    {
        Debug.Log("clicked on");
        anim.SetTrigger("Click");
    }
}
