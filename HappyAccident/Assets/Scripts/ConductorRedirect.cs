using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorRedirect : MonoBehaviour {
	public float speed = 2.0f;
	public float shiftDis;
	Rigidbody2D m_Rigidbody;
	Vector2 MovePos;
	void Start() {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
	}
	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			colInfo.GetComponent<Rigidbody2D>().velocity = transform.up * speed;
			if ((m_Rigidbody.rotation >= -1 && m_Rigidbody.rotation <= 1) || (m_Rigidbody.rotation >= 179 && m_Rigidbody.rotation <= 181) || (m_Rigidbody.rotation <= -179 && m_Rigidbody.rotation >= -181)) {
				MovePos = new Vector2(m_Rigidbody.position.x, colInfo.transform.position.y);
			}
			else if ((m_Rigidbody.rotation >= 89 && m_Rigidbody.rotation <= 91) || (m_Rigidbody.rotation >= 269 && m_Rigidbody.rotation <= 271) || (m_Rigidbody.rotation <= -89 && m_Rigidbody.rotation >= -91)) {
				MovePos = new Vector2(colInfo.transform.position.x, m_Rigidbody.position.y);
			}
			colInfo.transform.position = MovePos;
			colInfo.transform.rotation = m_Rigidbody.transform.rotation;
		}
	}
}
