using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiMainMenu : MonoBehaviour {
    public Button play;
    public Button mute;
    public Button quit;
    public Animator cameraPlay;
   

    // Use this for initialization
    void Start ()
    {
        play.onClick.AddListener(OnPlay);
        mute.onClick.AddListener(OnMute);
        quit.onClick.AddListener(OnQuit);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnPlay()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        cameraPlay.SetTrigger("Play");
        UiInGameMenu.instance.Show();
        Gamemanager.gameState = GameState.Play;

    }
    private void OnMute()
    {
        //gaan die audio sorce volume ==0
    }
    private void OnQuit()
    {
        Application.Quit();
    }
}
