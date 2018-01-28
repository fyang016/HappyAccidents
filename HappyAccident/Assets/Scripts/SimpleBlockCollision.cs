using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBlockCollision : MonoBehaviour {
	public GameObject lightningEffect;

	void OnCollisionEnter2D(Collision2D collision){
		if(collision.collider.CompareTag("Energy")){
			Instantiate (lightningEffect, collision.collider.transform.position, Quaternion.identity);
		}
	}
}
