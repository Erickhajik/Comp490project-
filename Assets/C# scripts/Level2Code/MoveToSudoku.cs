using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToSudoku : MonoBehaviour
{
    public Camera SudokuCamera;
    public Camera PlayerCamera;
    public GameObject Player;
    public GameObject SudokuCanvas;
    public void OnMouseDown()
    {
        PlayerCamera.gameObject.SetActive(false);
        Player.SetActive(false);
        Screen.SetResolution(2560, 1600, true);
        ZombieFollow.willfollow=false;

    SudokuCamera.gameObject.SetActive(true);
    SudokuCanvas.SetActive(true);
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    Level2Puzzle1.StartTimer();
    }
}
