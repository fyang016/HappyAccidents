using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterEnergy : MonoBehaviour {

	public Rigidbody2D EnergyObj;
	Rigidbody2D m_Rigidbody;
	public float timeInterval = 1f;
	public float speed = 10.0f;
	public float distanceSpawn = 2.0f;

	void Start() {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		InvokeRepeating("SpawnEnergy", 0.0f,  timeInterval);
	}

	void SpawnEnergy() {
		Rigidbody2D energyClone;
		Vector2 energySpawn = transform.position + (distanceSpawn * m_Rigidbody.transform.up) ;
		energyClone = Instantiate(EnergyObj, energySpawn, Quaternion.identity);
		energyClone.velocity = m_Rigidbody.transform.up * speed;
		energyClone.rotation = m_Rigidbody.rotation;
	}
}
