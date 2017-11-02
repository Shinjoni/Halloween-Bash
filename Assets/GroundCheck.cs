using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

	private PC player;

	// Use this for initialization
	void Start () {

		player = gameObject.GetComponentInParent<PC>(); 
	}

	void OnTriggerEnter2D( Collider2D col)
	{
		player.isGrounded = true;
	}
	void OnTriggerStay2D(Collider2D col)
	{
		player.isGrounded = true;
	}
	void OnTriggerExit2D(Collider2D col)
	{
		player.isGrounded = false;
	}


}
