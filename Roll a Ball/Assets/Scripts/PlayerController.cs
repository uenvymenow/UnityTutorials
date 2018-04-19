using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	// Creates a float for handling movement speed
	public float speed;

	// Creates a Text variable to hold the reference for the count text object
	public Text countText;

	// Creates a Text variable to hold the reference for the win text object
	public Text winText;

	// Creates a variable to hold for accessing the RigidBody componenet
	private Rigidbody rb;

	// Creates a variable to hold the count of objects collected
	private int count;

	void Start()
	{
		// Accesses RigidBody component
		rb = GetComponent<Rigidbody> ();

		// Sets the count variable to 0 
		count = 0;
		SetCountText ();
		winText.text = "";
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

	// Creates a method to retrieve the OnTriggerEvent collider
	void OnTriggerEnter(Collider other) 
	{
		// Checks if the player object collides with the "Pick Up" object and if so, then deactivates the "Pick Up" object
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive(false);
			count += 1;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12) 
		{
			winText.text = "You Win!";
		}
	}
}
