using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Animation : MonoBehaviour
{
    public Animator ani;
    Animation anim;
    public KeyCode buttenPress ;

    private void Awake()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(buttenPress))
        {
            ani.SetTrigger("Hit");
       
        }
      
            
    }
}
