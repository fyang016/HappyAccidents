using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterParticle : MonoBehaviour {
	public GameObject emitterEffect;
	public string userTag;

	void OnTriggerEnter2D (Collider2D conInfo) {
		if (conInfo.tag == userTag) {
			Instantiate (emitterEffect, transform.position, Quaternion.identity);
		}
	}

}
