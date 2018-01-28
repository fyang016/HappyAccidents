using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCollide : MonoBehaviour {
	public GameObject deathEffect;

	void OnCollisionEnter2D (Collision2D collideInfo) {
		if (collideInfo.collider.tag == "Obstacle" || collideInfo.collider.tag == "Wave") {
			Instantiate (deathEffect, transform.position, Quaternion.identity);
			Destroy (gameObject);
		}
	}

}
