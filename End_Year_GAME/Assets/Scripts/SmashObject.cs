using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SmashObject : MonoBehaviour
{
	public KeyCode key;

	public GameObject smashTarget = null;

	public GameObject partecal;

	private void Update()
	{
		if (Input.GetKeyDown(key))
		{
			DoSmash();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Smashable>() != null)
		{
			other.GetComponent<Smashable>().ObjectState = ObjectState.Smash;
			smashTarget = other.gameObject;
		}
	}

	private void DoSmash()
	{
		if (smashTarget != null)
		{
			
			if (smashTarget.GetComponent<Smashable>().tipe == "Nut")
			{
				//gets Score from ScoreManager
				ScoreManager.instance.AddScore();
			}
			if (smashTarget.GetComponent<Smashable>().tipe == "Banana")
			{
				// sets the game state to game over
				Gamemanager.gameState = GameState.GameOver;
				UiGameOver.instance.ShowGameOver();
			}
			//insantiat the partiacl at smash taarget . position
			Instantiate(partecal, transform.position, Quaternion.identity);
			Destroy(smashTarget);


		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.GetComponent<Smashable>() != null)
		{
			other.GetComponent<Smashable>().ObjectState = ObjectState.TooLate;
			smashTarget = null;
		}
	}
}