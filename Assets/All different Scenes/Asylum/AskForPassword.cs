using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskForPassword : MonoBehaviour
{
    public Camera MainCamera;
    public Camera DoorPassCamera;
    public Canvas DoorPassCanvas;
    private void OnMouseDown()
    {
        MainCamera.gameObject.SetActive(false);
        DoorPassCamera.gameObject.SetActive(true);
        DoorPassCanvas.gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None; 
        Debug.Log("door clicked");
    }
}
