using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SmashObject : MonoBehaviour
{
	public KeyCode key;

	public static GameObject smashTarget = null;

	//   public Button smashButton;
	//public for partical
	public GameObject partecal;

	private void Start()
	{
	}


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
			// Scorecontroller.UpdateScore(smashTarget.GetComponent<Smashable>().score);
			// dit gaan n compatere tag moet gebruik om the weet of dit n punt moet by sit of game over gee.
			//hoe kry ek dit of van n klomp hitzones als na net een score te wys 
			if (smashTarget.GetComponent<Smashable>().tipe == "Nut")
			{
				//gets Score from ScoreManager
				ScoreManager.instance.AddScore();
			}
			if (smashTarget.GetComponent<Smashable>().tipe == "Banana")
			{
				ScoreManager.instance.MinisScore();
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