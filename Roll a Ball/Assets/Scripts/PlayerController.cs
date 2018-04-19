using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Creates a float for handling movement speed
	public float speed;

	// Creates a variable to hold for accessing the RigidBody componenet
	private Rigidbody rb;

	void Start()
	{
		// Accesses RigidBody component
		rb = GetComponent<Rigidbody> ();
	}

	void Update() // Update called before rendering frame. Most game code goes here
	{
		
	}

	void FixedUpdate() // Called just before performing any physics calculations. Where physics code goes
	{
		// Gets current positions once movement keys are pressed
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Creates a new movement vector to use in add force
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Adds force when movement keys are pressed according to the movement Vector created
		rb.AddForce (movement * speed);
	}

}
