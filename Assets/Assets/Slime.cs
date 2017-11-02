using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class Slime : MonoBehaviour {
	private float volume;
	public float speed;
	Rigidbody2D slimeBody;
	private int direction;
	public Transform playerLocation;
	public Transform slimeLocation;

	AudioSource audio;
	public AudioClip slimeScream;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		volume = 1 / (Mathf.Abs(slimeLocation.position.x - playerLocation.position.x));
		transform.position = new Vector2 (transform.position.x + speed, transform.position.y);
		audio.PlayOneShot (slimeScream, volume);
	}
}
