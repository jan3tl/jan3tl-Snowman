using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public GameObject StartScreen;
public GameObject PlayScreen;

public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Button StartButton;

    public void StartGame()
    {
        this.Message.text = "Can you save the Snowman?";
        this.StartButton.gameObject.SetActive(false);
        this.StartScreen.GameObject.SetActive(false);
        this.PlayScreen.GameObject.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.StartScreen.GameObject.SetActive(true);
        this.PlayScreen.GameObject.SetActive(false);
    }

}



