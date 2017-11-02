using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpiderSense : MonoBehaviour {
	public Rigidbody2D spiderBody;
	// Use this for initialization
	AudioSource audio;
	public AudioClip ambient;
	public AudioClip attack;
	private Vector3 spiderStart;

	void Start () {
		spiderBody.constraints = RigidbodyConstraints2D.FreezePositionY;
		spiderStart = transform.position;
	}
			
	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Player") {
			spiderBody.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
			StartCoroutine (Delay());
		}
	}

	IEnumerator Delay()
	{
		yield return new WaitForSeconds(5);
		transform.position = spiderStart;
		spiderBody.constraints = RigidbodyConstraints2D.FreezePositionY;
	}
}
