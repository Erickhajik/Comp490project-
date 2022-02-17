using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCamfBeg : MonoBehaviour
{
    public Camera MainCamera;
    public Camera CipherPuzzleCamera;
    public Canvas CipherCanvas;
    public Canvas DoorPass;
    public Camera DoorpassCam;
    
    void Start()
    {
        DoorPass.gameObject.SetActive(false);
        DoorpassCam.gameObject.SetActive(false);
        CipherPuzzleCamera.gameObject.SetActive(false);
        CipherCanvas.gameObject.SetActive(false);
        MainCamera.gameObject.SetActive(true);
        
       
    }

    
}
