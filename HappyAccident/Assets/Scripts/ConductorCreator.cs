using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorCreator : MonoBehaviour {
	public GameObject CondStart;
	public GameObject CondMid;
	public GameObject CondEnd;

	public GameObject CondContainer;

	public int numberOfConductor = 3;

	public float numberToIncre = 1.0f;



	void start() {

	}

	void FixedUpdate() {
		if(Input.GetKeyDown("g")) {
			createCond(numberOfConductor, CondContainer);
		}
	}

	void createCond(int numParts, GameObject CondContainer) {
		/*foreach (Transform child in transform) {
			GameObject.Destroy (child.gameObject);
		}*/
		for (int i = 0; i < numParts; i++) {
			Vector2 newPos = CondContainer.transform.position + (CondContainer.transform.up * i * numberToIncre);
			if (i == 0) {
				Instantiate(CondStart, newPos, CondContainer.transform.rotation, CondContainer.transform);
			} else if (i == numParts - 1) {
				Instantiate(CondEnd, newPos, CondContainer.transform.rotation, CondContainer.transform);
			} else {
				Instantiate(CondMid, newPos, CondContainer.transform.rotation, CondContainer.transform);
			}

		}
	}
}

