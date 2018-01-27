﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorCreator : MonoBehaviour {
	public GameObject CondStart;
	public GameObject CondMid;
	public GameObject CondEnd;

	public GameObject CondContainer;
	public SpriteRenderer CondRender;
	public int numberOfConductor = 3;
	public int lowerCondLimit = 3;
	public int upperCondLimit = 6;

	public float numberToIncre = 1.0f;


	SpriteRenderer rend;

	[SerializeField] bool isSelected = false;

	void start() {
		
	}

	void OnMouseDown() {
		isSelected = !isSelected;
		Debug.Log ("Hit");
		if (isSelected) {
			CondRender.color = (Color.red);
		}
		else if (!isSelected) {
			CondRender.color = new Color(255,255,255);
		}
	}

	void FixedUpdate() {
		if (isSelected) {
			if (Input.GetKeyDown ("g")) {
				createCond (numberOfConductor, CondContainer);
			}
			else if (Input.GetKeyDown(KeyCode.Z)) {
				if (numberOfConductor < upperCondLimit) {
					numberOfConductor++;
					createCond (numberOfConductor, CondContainer);
				}
			}
			else if (Input.GetKeyDown(KeyCode.X)) {
				if(numberOfConductor > lowerCondLimit) {
					numberOfConductor--;
				    createCond (numberOfConductor, CondContainer);
				}
			}
			if (Input.GetKeyDown(KeyCode.Space))
			{
				transform.Rotate(0, 0, 90);
			}
		}
	}

	void createCond(int numParts, GameObject CondContainer) {
		foreach (Transform child in transform) {
			GameObject.Destroy (child.gameObject);
		}
		for (int i = 1; i < numParts; i++) {
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
