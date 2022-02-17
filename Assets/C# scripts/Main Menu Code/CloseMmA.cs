using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMmA : MonoBehaviour
{
  public Camera MainGameCam;
  public Camera PasswordMatchCam;
  // public Camera MatchCam;
  public Canvas MainGameCanvas;
  public Canvas PasswordMatchCanvas;
  // public Canvas MatchCanvas;
  public void m()
  {
    MainGameCam.gameObject.SetActive(true);
    MainGameCanvas.gameObject.SetActive(true);
    PasswordMatchCam.gameObject.SetActive(false);
    // MatchCam.gameObject.SetActive(false);
    PasswordMatchCanvas.gameObject.SetActive(false);
    // MatchCanvas.gameObject.SetActive(false);
    
  }
    
}
