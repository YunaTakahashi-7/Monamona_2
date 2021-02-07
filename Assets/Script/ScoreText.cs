using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public static int score = 10;
    public Text TextofScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextofScore.text = "" + score;
    }

    void AddScore()
    {
        score += 10;
        TextofScore.text = "" + score;
    }
}
