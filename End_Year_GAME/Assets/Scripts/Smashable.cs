using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ObjectState
{
	Ignore,
	Smash,
	TooLate
}

public class Smashable : MonoBehaviour
{
	public ObjectState ObjectState = ObjectState.Ignore;
	public int score = 1;
	public string tipe = "Undefind";
}