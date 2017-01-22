using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;        // The player's score.

    private Text text;               // Reference to the Text component.

    bool firstUpdate;

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }

    void Update()
    {
        // reset the scores caused by collision before the game started 
        if(!firstUpdate)
        {
            firstUpdate = true;
            score = 0;
        }

        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}