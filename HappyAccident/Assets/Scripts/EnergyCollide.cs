using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCollide : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D collideInfo) {
		if (collideInfo.collider.tag == "Obstacle") {
			Destroy (gameObject);
		}
		if (collideInfo.collider.tag == "Wave") {
			Destroy (gameObject);
		}
	}
}
