using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMove : MonoBehaviour {

	public Vector2 velocity;
	// Update is called once per frame
	void FixedUpdate () {
		GetComponent<Rigidbody2D> ().velocity = velocity;
	}
}
