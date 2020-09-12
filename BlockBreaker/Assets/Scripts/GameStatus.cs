using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour {

    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] int currentScore = 0;
    [SerializeField] float gameTime = 0.5f;
    [SerializeField] TextMeshProUGUI ScoreText;
    // Use this for initialization
    void Start () {
        ScoreText.text = currentScore.ToString();
	}
	
	// Update is called once per frame
	void Update () {
    //    PowerUp();
		
	}
    public void AddToScore()
    {
        currentScore = currentScore + pointsPerBlockDestroyed;
        ScoreText.text = currentScore.ToString();
    }

    public void PowerUp()
    {
     Time.timeScale = 0.5f;

    }
}
