using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFromHow : MonoBehaviour
{
   public GameObject player;
   public Camera canvasCam;
   public Canvas howTocavas;
   public void moveToGame()
   {
      MainGameTimer.StartTimer();
      canvasCam.gameObject.SetActive(false);
      howTocavas.gameObject.SetActive(false);
      player.gameObject.SetActive(true);
   }
}
