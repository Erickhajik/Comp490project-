using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    public bool key;
    void Start()
    {
        key = false;
        


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
        key = true;
        Debug.Log("clicked on key");
    }
}
