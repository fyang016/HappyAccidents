using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScroll : MonoBehaviour {
	Rigidbody2D parent;
	public float creditSpeed = 1.0f;
	public bool isRunning = true;

	public void toggleIsRunning() {
		isRunning = !isRunning;
	}

	void Start() {
		parent = GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		if (isRunning) {
			parent.velocity = (parent.transform.up * creditSpeed);
		}
	}
		
}
