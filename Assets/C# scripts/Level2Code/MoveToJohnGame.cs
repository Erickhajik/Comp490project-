using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToJohnGame : MonoBehaviour
{
    public GameObject playerCamra;
    public GameObject gameCamra;
    public GameObject playerCan;
    public GameObject gameCan;
    
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        ZombieFollow.willfollow=false;
   playerCamra.SetActive(false);
   gameCamra.SetActive(true);
   playerCan.SetActive(false);
    gameCan.SetActive(true);
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
    Level2Puzzle2.StartTimer();
    }
}
