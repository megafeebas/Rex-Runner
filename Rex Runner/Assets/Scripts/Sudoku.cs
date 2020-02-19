using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sudoku : MonoBehaviour
{
    bool counted = false;
    public Text Score;
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("Score");
        Score = scoreGO.GetComponent<Text>();
        Score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x < -12)
        {
            Destroy(gameObject);
        }
        else if(counted == false && gameObject.transform.position.x < -6)
        {
            int score = int.Parse(Score.text);
            score += 1;
            Score.text = score.ToString();
            int hScore = int.Parse(HighScore.text);
            if (score > hScore)
            {
                hScore = score;
                HighScore.text = hScore.ToString();
            }
            counted = true;
        }
    }
}
