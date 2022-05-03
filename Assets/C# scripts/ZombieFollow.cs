using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieFollow : MonoBehaviour
{
  public NavMeshAgent enemy;
  public Transform Player;

  public static bool willfollow=true;
  Vector3 home = new Vector3(-27.30532f,-0.006185174f,-30.09311f);

  void Start() {
  }

  void Update(){

    if(willfollow)
    {
    enemy.SetDestination(Player.position);

    }
    else
    {
      enemy.SetDestination(home);
    }
  }
}