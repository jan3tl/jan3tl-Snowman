using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WordGuesser;


public class GameController : MonoBehaviour
{
    public UnityEngine.UI.Text Message;
    public UnityEngine.UI.Text GetWord;
    public UnityEngine.UI.Text GetGuessedLetters;
    public UnityEngine.UI.Text CheckGuess;
    public UnityEngine.UI.Text TurnsLeft;
    public UnityEngine.UI.Button StartButton;
    public GameObject StartScreen;
    public GameObject PlayScreen;
    public GameObject GameOver;
    public GameObject GameWon;
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;

    WordGuesser.WordSelector mySelector = WordGuesser.WordSelector.LoadFromString("apple banana grape");

    public void StartGame()
    {
        string randomWord = mySelector.GetWord();
        //this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }

    public void OpenStartScreen()
    {
        this.GameWon.SetActive(false);
        this.GameOver.SetActive(false);
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
        

    }

    public void Start()
    {
        this.PlayScreen.SetActive(false);
        this.StartScreen.SetActive(true);
    }

    public void SubmitGuess()
    {
       
       Debug.Log(this.guessingGame.CheckGuess(this.PlayerGuess.text));
       
       GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
       GetWord.text = this.guessingGame.GetWord();
       
       if(this.guessingGame.IsGameWon())
       {
           this.GameWon.SetActive(true);
       }
       else if (this.guessingGame.IsGameOver())
       {
           this.GameOver.SetActive(true);
       }
       

       PlayerGuess.text = string.Empty;

    }


}







