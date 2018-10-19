using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Zone : MonoBehaviour {
    public KeyCode keyPress;
    public bool itTrigger;

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
      
      
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (Input.GetKeyDown(keyPress)  )
        {
            Destroy(other.gameObject);
        } 
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

}
