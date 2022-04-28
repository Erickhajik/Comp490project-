using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToWord : MonoBehaviour
{
    public Camera WordCamera;
    public Camera PlayerCamera;
    public GameObject Player;
    public GameObject WordCanvas;
    public void OnMouseDown()
    {
        PlayerCamera.gameObject.SetActive(false);
        Player.SetActive(false);
        Screen.SetResolution(1920, 1080, true);

        WordCamera.gameObject.SetActive(true);
        WordCanvas.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        Level2Puzzle3.StartTimer();
}
}