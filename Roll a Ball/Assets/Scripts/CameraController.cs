using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	// Creates a GameObject variable to access the player and a Vector3 variable to hold the offset position
	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// LateUpdate runs every frame, but after all items have been processed in update
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
