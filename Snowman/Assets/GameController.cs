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
    public UnityEngine.UI.Text CorrectGuess;
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
        this.guessingGame = new WordGuesser.WordGame(randomWord, 5);
        Debug.Log(this.guessingGame.GetWord());
        Debug.Log(this.guessingGame.GetFullWord());
        
        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        GetWord.text = this.guessingGame.GetWord();
        CheckGuess.text = string.Empty;

        this.StartScreen.SetActive(false);
        this.PlayScreen.SetActive(true);
        this.GameOver.SetActive(false);
        this.GameWon.SetActive(false);
    
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
        this.GameWon.SetActive(false);
        this.GameOver.SetActive(false);
    }

    public void SubmitGuess()
    {

        CheckGuess.text = this.guessingGame.CheckGuess(this.PlayerGuess.text);

        GetGuessedLetters.text = this.guessingGame.GetGuessedLetters();
        GetWord.text = this.guessingGame.GetWord();

        int remainingGuesses = this.guessingGame.GetGuessLimit() - this.guessingGame.GetIncorrectGuesses();
        TurnsLeft.text = $"You have {remainingGuesses} guesses left.";

        if (this.guessingGame.IsGameWon())
        {
            this.GameWon.SetActive(true);
            this.GameOver.SetActive(false);
            this.PlayScreen.SetActive(false);
            this.StartScreen.SetActive(false);
        }
        else if (this.guessingGame.IsGameOver())
        {
            this.GameOver.SetActive(true);
            this.GameWon.SetActive(false);
            this.PlayScreen.SetActive(false);
            this.StartScreen.SetActive(false);
            this.CorrectGuess.text = $"The correct word was {this.guessingGame.GetFullWord()}";
        }


        PlayerGuess.text = string.Empty;

    }


}







