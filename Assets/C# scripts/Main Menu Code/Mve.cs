using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mve : MonoBehaviour
{
    public Canvas c;
    public Canvas c1;
    public Camera m;
    public Camera m1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mov()
    {
        Puzzle3.StopTimer();
        c1.gameObject.SetActive(true);
        m1.gameObject.SetActive(true);
        c.gameObject.SetActive(false);
        m.gameObject.SetActive(false);
        //
      
    }
}
