using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiGameOver : MonoBehaviour
{
	public static UiGameOver instance;
	public Button play;
    public Button mute;
    public Button quit;
    public bool isGameOver = false;

    // Use this for initialization
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
		play.onClick.AddListener(OnPlay);
		quit.onClick.AddListener(OnQuit);
	}

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.instance.score < 0)
        {
				print("lol");
            if (isGameOver)
            {
                isGameOver = false;
                GetComponent<CanvasGroup>().alpha = 1;
                GetComponent<CanvasGroup>().interactable = true;
                GetComponent<CanvasGroup>().blocksRaycasts = true;
				Gamemanager.gameState = GameState.GameOver;
				ScoreManager.instance.score = 0;
            }
            else
            {
                isGameOver = true;
                GetComponent<CanvasGroup>().alpha = 0;
                GetComponent<CanvasGroup>().interactable = false;
               GetComponent<CanvasGroup>().blocksRaycasts = false;
               Gamemanager.gameState = GameState.Play;
				print("wow");
            }


        }
    }
    private void OnPlay()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
		Gamemanager.gameState = GameState.Play;

	}
    private void OnMute()
    {
        //gaan die audio sorce volume ==0
        //  audioSource.mute = false;

    }
    private void OnQuit()
    {
        Application.Quit();
    }
}
