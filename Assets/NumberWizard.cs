using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
    // Use this for initialization
    int max;
	int min;
    int guess;

    int maxGuessesAllowed = 8;

    public Text text;
    public bool outOfGuesses = false;
	
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
        outOfGuesses = true;
    }


    void NextGuess ()
	{

		guess = (max + min) / 2;

		maxGuessesAllowed -= 1;

		if (outOfGuesses) {
			SceneManager.LoadScene ("Win");
		}

		if (maxGuessesAllowed <= 0) {
			//SceneManager.LoadScene("Win");
			outOfGuesses = true;
		}
        
		text.text = guess.ToString ();   
	}
}
