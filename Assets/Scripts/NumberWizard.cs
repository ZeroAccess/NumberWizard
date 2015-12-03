using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame ()
    {
        max = 1000;
        min = 1;
        guess = 500;

        print("Welcome to Number Wizard");
        print("Pick a number in your head between " + min + "and " + max + " but, don't tell me");
        print("Up Arrow is higher and Down Arrow is lower. If number is correct press Enter.");
        print("Is the number higher or lower than " + guess + " ?");

        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("UpArrow has been pressed.");
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("DownArrow has been pressed.");
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
        }

    }
}
