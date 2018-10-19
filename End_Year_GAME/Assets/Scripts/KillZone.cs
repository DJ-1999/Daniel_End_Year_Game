using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Banana")
        {
            Destroy(col.gameObject);
        }
        
    

    }

}
