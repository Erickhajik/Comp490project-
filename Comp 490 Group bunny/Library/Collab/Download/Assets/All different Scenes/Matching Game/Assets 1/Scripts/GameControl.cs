using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControl : MonoBehaviour
{
    public GameObject m;
    GameObject token;
    public Canvas game;
    public Canvas error;
    public Camera m1;  
    public Camera m2;
    List<int> faceIndexes = new List<int> { 0, 1, 2, 3, 0, 1, 2, 3 };
    public static System.Random rnd = new System.Random();
    public int shuffleNum = 0;
    int[] visibleFaces = { -1, -2 };
    private int a = 0;
    // public Text written;
    void Start()
    {
        m2.gameObject.SetActive(false);
        error.gameObject.SetActive(false);
        error.gameObject.SetActive(true);
        int originalLength = faceIndexes.Count;
        float yPosition = 2.3f;
        float xPosition = 45f;
        for (int i = 0; i < 7; i++)
        {
            shuffleNum = rnd.Next(0, (faceIndexes.Count));
            var temp = Instantiate(token, new Vector3(
                xPosition, yPosition, 0),
                Quaternion.identity);
            temp.GetComponent<MainToken>().faceIndex = faceIndexes[shuffleNum];
            faceIndexes.Remove(faceIndexes[shuffleNum]);
            xPosition = xPosition + 4;
            if (i == (originalLength/2 - 2))
            {
                yPosition = -2.3f;
                xPosition = 45f;
            }
        }
        token.GetComponent<MainToken>().faceIndex = faceIndexes[0];
    }

     void Update()
     {
         if (a == 4)
         {
    m.SetActive(true);
    Puzzle3.StopTimer();
    
         }
     }

    public bool TwoCardsUp()
    {
        bool cardsUp = false;
        if(visibleFaces[0] >= 0 && visibleFaces[1] >= 0)
        {
            cardsUp = true;
        }
        return cardsUp;
    }

    public void AddVisibleFace(int index)
    {
        if(visibleFaces[0] == -1)
        {
            visibleFaces[0] = index;
        }
        else if (visibleFaces[1] == -2)
        {
            visibleFaces[1] = index;
        }

    }

    public void RemoveVisibleFace(int index)
    {
        if (visibleFaces[0] == index)
        {
            visibleFaces[0] = -1;
        }
        else if (visibleFaces[1] == index)
        {
            visibleFaces[1] = -2;
        }
    }

    public bool CheckMatch()
    {
        bool success = false;
        if (visibleFaces[0] == visibleFaces[1])
        {
            visibleFaces[0] = -1;
            visibleFaces[1] = -2;
            success = true;
            a++;
        }
       
        return success;
    }

    private void Awake()
    {
        token = GameObject.Find("Token");
    }

   
}