﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;

	// Use this for initialization
	void Start () {
        StartGame();
    }

    void StartGame ()
    {
        Debug.Log("Welcome to the number wizard!");
        Debug.Log("Pick a number, don't tell me what it is!");
        Debug.Log("The highest number you can pick is: " + max + ".");
        Debug.Log("The lowest number you can pick is: " + min + ".");
        Debug.Log("Tell me if your number is higher or lower than: " + guess + ".");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
            Debug.Log("I guessed too low! Is it higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
            Debug.Log("I guessed too high! Is it higher or lower than: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I got the number correct!");
            RestartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }

    void RestartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        StartGame();
    }
}
