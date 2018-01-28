using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditTrigger : MonoBehaviour {
	public string creditTag;
	public CreditsScroll trigger;

	[SerializeField] bool haveTriggered = false;

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (!haveTriggered) {
			if (colInfo.tag == creditTag) {
				trigger.toggleIsRunning ();
				haveTriggered = true;
			}
		}
	}
}
