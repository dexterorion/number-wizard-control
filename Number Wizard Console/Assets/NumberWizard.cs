using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int max, min, guess;

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Weolcome to number wizard, yo");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("Highest number you can pick is: " + max);
        Debug.Log("Lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max++;
    }

    void UpdateFrame()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess(guess);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            PrintRightGuess(guess);
        }
    }

    void NextGuess(int g)
    {
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + g);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
    }

    void PrintRightGuess(int g)
    {
        Debug.Log("Your number is: " + g);
        StartGame();
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateFrame();
    }
}
