using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SameNameError1 : MonoBehaviour
{
    public GameObject SameName;
    // Start is called before the first frame update
    void Start()
    {
        SameName.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
