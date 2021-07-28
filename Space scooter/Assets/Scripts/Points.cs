using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static Points instance;

    public Text scoreText;
    public Text highScoreText;
    int score = 0;
    int highScore = 0;

    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        scoreText.text = "POINTS: " + score.ToString();
        highScoreText.text = "HIGHSCORE: " + highScore.ToString();
    }

    public void AddPoint(){
        score += 1;
        scoreText.text = "POINTS: " + score.ToString();
        if(highScore < score)
        PlayerPrefs.SetInt("highScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
