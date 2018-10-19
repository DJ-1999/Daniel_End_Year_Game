using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOfObjects : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] prefabs;
	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("SpawnObject", 2, 3);
	}
	
	void SpawnObject()
    {
        if (Gamemanager.gameState == GameState.Play)
        {
            Transform point = points[Random.Range(0, points.Length)];
            GameObject items = prefabs[Random.Range(0, prefabs.Length)];

            Instantiate(items, point.position, point.rotation);
        }



    
    }
}
