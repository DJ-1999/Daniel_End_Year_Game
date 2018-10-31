using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{ 
	// Keeps track of score
	public int score = 0;

	// Singeltin
	public static ScoreManager instance;
	
	public Text countText;

	void Start()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
		}

		setCountText();
	}

	
	// Adds a point
	public void AddScore()
	{
		score++;
		setCountText();
	}

	// Takes a point away
	public void MinisScore()
	{
		score--;
		setCountText();
	}

	// Sets the score count display
	public void setCountText()
	{    //Sets game over text if score lower than zero
		if (score < 0)
		{
			countText.text = "GAME OVER";
			Gamemanager.gameState = GameState.GameOver;
			UiGameOver.instance.ShowGameOver();
			return;
		}
		countText.text = "Score: " + score.ToString();
	}
}
