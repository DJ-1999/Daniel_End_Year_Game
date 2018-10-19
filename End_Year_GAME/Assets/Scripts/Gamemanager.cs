using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    MainMenu,
    Play,
    Pause,
    GameOver
}

public class Gamemanager : MonoBehaviour
{
    public static GameState gameState;
	// Use this for initialization
	void Start ()
    {
        gameState = GameState.MainMenu;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
