using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorRedirect : MonoBehaviour {
	public float speed = 2.0f;
	public float shiftDis;
	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			colInfo.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
			//colInfo.transform.position = transform.position.x;
		}
	}
}
