using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveToMatching : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera cam1P;
    public Camera cam2;
    public Canvas Can1P;
    public Canvas Can2;
    public GameObject token;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Puzzle3.StartTimer();
        cam1P.gameObject.SetActive(false);
        Can1P.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
        Can2.gameObject.SetActive(true);
        token.SetActive(true);
    }
}