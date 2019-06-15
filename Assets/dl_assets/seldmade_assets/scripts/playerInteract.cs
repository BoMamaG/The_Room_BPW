using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInteract : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
	}
	
	
    

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "pickup" && Input.GetKeyDown(KeyCode.E))
        {
            col.GetComponent<inventory>().keyCard = true;
        }

    }
}
