using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoveToMaze : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text1;
    public Text text2;
    public GameObject maze;
    public FirstPersonController Move;
    public TextDisplay textDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        maze.SetActive(true);
        text2.gameObject.SetActive(false);
        text1.gameObject.SetActive(false);
        Move.MoveToMaze();
        textDisplay.textElement.enabled = true; 
        Puzzle2.StartTimer();       
    }
}
