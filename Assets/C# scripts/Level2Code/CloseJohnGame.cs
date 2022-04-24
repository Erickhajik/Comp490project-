using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseJohnGame : MonoBehaviour
{
    public GameObject playerCamra;
    public GameObject gameCamra;
    public GameObject playerCan;
    public GameObject gameCan;
    // Start is called before the first frame update
    public void close()
    {
        playerCamra.SetActive(true);
        gameCamra.SetActive(false);
        playerCan.SetActive(true);
        gameCan.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
