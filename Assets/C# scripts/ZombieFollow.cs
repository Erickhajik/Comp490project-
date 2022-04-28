using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombieFollow : MonoBehaviour
{
  public NavMeshAgent enemy;
  public Transform Player;

  public static bool willfollow=true;

  void Start() {
  }

  void Update(){

    if(willfollow)
    {
    enemy.SetDestination(Player.position);

    }
  }
}