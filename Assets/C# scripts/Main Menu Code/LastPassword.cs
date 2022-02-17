using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastPassword : MonoBehaviour
{
    public Canvas Endpass;
    public Camera EndpassCam;
    public Camera MainCamera;
    private void OnMouseDown()
    {
        Endpass.gameObject.SetActive(true);
        EndpassCam.gameObject.SetActive(true);
        MainCamera.gameObject.SetActive(false);
    }
}
