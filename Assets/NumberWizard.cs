using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    // Use this for initialization
    int max;
	int min;
    int guess;

    int maxGuessesAllowed = 8;

    public Text text;
    public bool correctGuess = true;
	
	void Start () {
        StartGame();
	}

    public void GuessHigher() {
        min = guess;
        NextGuess();
    }

    public void GuessLower() {
        max = guess;
        NextGuess();
    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;

        max = max + 1;
    }

     public void SetBool() {
        correctGuess = false;
    }


    void NextGuess() {

        guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuessesAllowed -= 1;
        if (maxGuessesAllowed <= 0 && correctGuess == false) {
            Application.LoadLevel("Win");
        }
        
    }
}
