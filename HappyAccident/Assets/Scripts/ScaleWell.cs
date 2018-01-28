using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleWell : MonoBehaviour {
	Rigidbody2D m_Rigidbody;
	Collider2D m_Collider;
	public float scaleRadius = 2.0f;
	public float angularVelo = 90.0f;
	public bool isOn = true;

	public void toggleWell() {
		isOn = !isOn;
	}

	void Start () {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		m_Rigidbody.transform.localScale = new Vector2 (scaleRadius,scaleRadius);
		m_Collider = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isOn) {
			m_Rigidbody.transform.localScale = new Vector2 (0.0f, 0.0f);
			m_Collider.enabled = false;
		} else {
			m_Rigidbody.transform.localScale = new Vector2 (scaleRadius,scaleRadius);
			m_Rigidbody.angularVelocity = angularVelo;
			m_Collider.enabled = true;
		}
	}
}
