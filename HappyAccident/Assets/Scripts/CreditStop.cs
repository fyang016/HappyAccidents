using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditStop : MonoBehaviour {
	public string creditTag;

	[SerializeField] bool haveTriggered = false;

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (!haveTriggered) {
			if (colInfo.tag == creditTag) {
				colInfo.attachedRigidbody.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
				haveTriggered = true;
			}
		}
	}
}
