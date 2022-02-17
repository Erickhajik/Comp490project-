using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPuzzle : MonoBehaviour
{
    public Camera MainCamera;
    public Camera CipherPuzzleCamera;
    public Canvas CipherCanvas;
     
    
   
    
    private void OnMouseDown()
    {
        MainCamera.gameObject.SetActive(false);
        CipherPuzzleCamera.gameObject.SetActive(true);
        CipherCanvas.gameObject.SetActive(true);
        Debug.Log("camera change to puzzle");
    }
}