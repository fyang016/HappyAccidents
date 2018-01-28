using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditStop : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D colInfo) {
		colInfo.GetComponent<Rigidbody2D>().velocity = new Vector3 (0.0f, 0.0f, 0.0f);
	}
}
