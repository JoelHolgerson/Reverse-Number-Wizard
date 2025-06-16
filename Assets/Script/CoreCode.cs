using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoreCode : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI yourguess;
    [SerializeField] TextMeshProUGUI higherlower;
    [SerializeField] TextMeshProUGUI rules;

    int computerguess;
    int playerGuess;
    [SerializeField] int minValue = 1;
    [SerializeField] int maxValue = 100;

    private string input;

    void Start()
    {
        rules.text = ("I'm thinking of a number between " + minValue + " and " + maxValue);
        computerguess = Random.Range(minValue, maxValue + 1);
    }

    public void ReadstringInput(string s)
    {
        input = s;
        int playerGuess = int.Parse(s);
        yourguess.text = ("Your Guess is " + input);

        if (playerGuess < computerguess)
        {
            Higher();
        }
        else if (playerGuess > computerguess)
        {
            Lower();
        }
        else
        {
            correct();
        }
    }

    void Higher()
    {
        higherlower.text = ("Higher");
    }
    void Lower()
    {
        higherlower.text = ("Lower");
    }
    void correct()
    {
        higherlower.text = ("Correct");
    }
}

