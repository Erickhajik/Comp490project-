using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text textElement;
    public FirstPersonController firstPersonController;
    public MazeSpawner mazespawner;

    // Start is called before the first frame update
    void Start()
    {
        textElement.fontSize = 20;
        textElement.text = ("Collect Coins to Escape\n" + firstPersonController.NumberCoin + "/" + mazespawner.NumberOfCoin);
        if (firstPersonController.NumberCoin.Equals(mazespawner.NumberOfCoin))
        {
            textElement.text = ("Collect Coins to Escape\n" + firstPersonController.NumberCoin + "/" + mazespawner.NumberOfCoin + "\nYou Win");
        }
        textElement.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {
        textElement.text = ("Collect Coins to Escape\n" + firstPersonController.NumberCoin + "/" + mazespawner.NumberOfCoin);
        if(firstPersonController.NumberCoin.Equals(mazespawner.NumberOfCoin))
        {
            textElement.text = ("Collect Coins to Escape\n" + firstPersonController.NumberCoin + "/" + mazespawner.NumberOfCoin +"\nYou Win");
            textElement.enabled = false;
        }
    }
}
