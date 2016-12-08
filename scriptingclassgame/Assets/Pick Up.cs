using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
        }
    }
	
	
}
