using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
    // Use this for initialization
    int max;
	int min;
    int guess;

    int maxGuessesAllowed = 12;

    public Text text;
	
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

    void NextGuess ()
	{

		guess = Random.Range(max + 1,  min);
        text.text = guess.ToString ();  
		maxGuessesAllowed -= 1;

		if (maxGuessesAllowed <= 0) {
			SceneManager.LoadScene("Win");
		}
		 
	}
}
