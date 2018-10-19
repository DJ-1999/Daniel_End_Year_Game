using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMoveForward : MonoBehaviour
{

    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (Gamemanager.gameState == GameState.Play)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }


    }
}
