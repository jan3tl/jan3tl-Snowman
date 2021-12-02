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
    private WordGuesser.WordGame guessingGame;
    public UnityEngine.UI.InputField PlayerGuess;
    public void StartGame()
    {
        this.guessingGame = new WordGuesser.WordGame("apple", 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
    }

    public void OpenStartScreen()
    {
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
       PlayerGuess.text = string.Empty;
       this.guessingGame.GetWord();
       this.guessingGame.GetGuessedLetters();
       this.guessingGame.CheckGuess();
       int TurnsLeft;
       TurnsLeft = this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses();
       this.TurnsLeft;

    }

}



