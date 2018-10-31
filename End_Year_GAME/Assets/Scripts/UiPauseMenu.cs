using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPauseMenu : MonoBehaviour
{
    public Button play;
    public Button mute;
    public Button quit;
    public bool isPaused = false;
    public AudioSource audioSource;
    
    
    void Start ()
    {
        play.onClick.AddListener(OnPlay);
      
        quit.onClick.AddListener(OnQuit);
        audioSource = GetComponent<AudioSource>();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                isPaused = false;
                GetComponent<CanvasGroup>().alpha = 0;
                GetComponent<CanvasGroup>().interactable = false;
                GetComponent<CanvasGroup>().blocksRaycasts = false;
                Gamemanager.gameState = GameState.Play;
            }
            else
            {
                isPaused = true;
                GetComponent<CanvasGroup>().alpha = 1;
                GetComponent<CanvasGroup>().interactable = true;
                GetComponent<CanvasGroup>().blocksRaycasts = true;
                Gamemanager.gameState = GameState.Pause;
            }


        }

		
	}
    private void OnPlay()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

		if (isPaused)
		{
			isPaused = false;
			GetComponent<CanvasGroup>().alpha = 0;
			GetComponent<CanvasGroup>().interactable = false;
			GetComponent<CanvasGroup>().blocksRaycasts = false;
			Gamemanager.gameState = GameState.Play;
		}
		else
		{
			isPaused = true;
			GetComponent<CanvasGroup>().alpha = 1;
			GetComponent<CanvasGroup>().interactable = true;
			GetComponent<CanvasGroup>().blocksRaycasts = true;
			Gamemanager.gameState = GameState.Pause;
		}

	}
    private void OnMute()
    {
        

    }
    private void OnQuit()
    {
        Application.Quit();
    }
}
