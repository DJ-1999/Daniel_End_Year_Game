using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       Smashable smashableObject = other.GetComponent<Smashable>();

       // if (smashableObject != null)
        {
            if (smashableObject.tipe == "Nut")
            {
				
                ScoreManager.instance.MinisScore();
            }
        }
        Destroy(other.gameObject);
    }
}
