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
    
    // Use this for initialization
    void Start ()
    {
        play.onClick.AddListener(OnPlay);
      //  mute.onClick.AddListener(OnMute);
        quit.onClick.AddListener(OnQuit);
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
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
        //gaan die audio sorce volume ==0
        audioSource.mute = !audioSource.mute;

    }
    private void OnQuit()
    {
        Application.Quit();
    }
}
