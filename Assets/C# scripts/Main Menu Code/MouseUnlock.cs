using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseUnlock : MonoBehaviour
{
    void Start () {
 
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
    }

    // Update is called once per frame
    void Update () {
        
    }
}
