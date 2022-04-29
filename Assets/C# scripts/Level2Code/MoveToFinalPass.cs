using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToFinalPass : MonoBehaviour
{
    public Camera playerCamer;
    public Camera computerCamer;
    public GameObject playerCanvas;
    public GameObject computerCanvas;
    public void OnMouseDown()
    {
    playerCamer.gameObject.SetActive(false);
   computerCamer.gameObject.SetActive(true);
     playerCanvas.SetActive(false);
   computerCanvas.SetActive(true);
    }
}
