using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterEnergy : MonoBehaviour {

	public Rigidbody2D EnergyObj;
	Rigidbody2D m_Rigidbody;
	public float timeInterval = 1f;
	public float speed = 10.0f;
	public float distanceSpawn = 2.0f;

	public bool isEmitting = true;
	public bool isRunning = true;

	void Start() {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		StartCoroutine ("SpawnCoroutine");
	}

	void FixedUpdate() {
		if (Input.GetKeyDown(KeyCode.RightShift))
		{
			isEmitting = !isEmitting;
		}
	}

	IEnumerator SpawnCoroutine () {
		while(isRunning) {
			if (isEmitting) {
				SpawnEnergy ();
				yield return new WaitForSeconds(timeInterval/2);
			}
			yield return new WaitForSeconds (timeInterval / 2);
		}
	}

	void SpawnEnergy() {
		Rigidbody2D energyClone;
		Vector2 energySpawn = transform.position + (distanceSpawn * m_Rigidbody.transform.up) ;
		energyClone = Instantiate(EnergyObj, energySpawn, Quaternion.identity);
		energyClone.velocity = m_Rigidbody.transform.up * speed;
		energyClone.rotation = m_Rigidbody.rotation;
	}
}
