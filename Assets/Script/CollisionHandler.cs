using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionHandler : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
        //Nabrak garis finish
		if (other.gameObject.tag == "Finish") 
		{   
            GetComponent<PlayerMovement>().enabled = false;
            FindObjectOfType<GameManager>().GameEnded(1);
		}

        //collect coins
        if(other.gameObject.CompareTag("Coins")){
			Destroy (other.gameObject);
		}

		//got powerup
		if(other.gameObject.CompareTag("Powerup")){
			Destroy (other.gameObject);
			GetComponent<Weapon>().enabled = true;
		}
	}
}
