using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public float strafingSpeed = 4.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		movement ();
	}

	// Player movement –> only will move along X axis with A + D
	void movement() {
		float moveHorizontal = Input.GetAxis ("Horizontal");

		// (x, y, z)
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);
		rigidbody.velocity = movement;


	}
}
