using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    //maak singeltin
    public static ScoreManager instance;
    //keep track of score
    public int score = 0;

    public Text countText;

    // Use this for initialization
    void Start ()
    {
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    // add score
    public void AddScore()
    {
        score++;
        setCountText();
    }

    public void MinisScore()
    {
        score--;
        setCountText();
    }

    public void setCountText()
    {
        countText.text = "Score: " + score.ToString();
    }
}
