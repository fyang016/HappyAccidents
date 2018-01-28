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
    public bool isConnected = false;
    float timer = 0.0f;
    float spawnInterval = 2f;

    string condName = "";

	void Start() {
		m_Rigidbody = GetComponent<Rigidbody2D> ();
		StartCoroutine ("SpawnCoroutine");
	}

    
    IEnumerator SpawnCoroutine () {
		if (isConnected)
        {            
            SpawnEnergy();
            yield return new WaitForSeconds(timeInterval / 2);
        }
	
	    yield return new WaitForSeconds (timeInterval / 2);
    }
    

        /*
    IEnumerator OnCollisionStay2D(Collision2D coll)
    {
        Debug.Log("touch");
        if (coll.gameObject.tag == "Conductor")
        {
            SpawnEnergy();
            yield return new WaitForSeconds(timeInterval / 2);
        }

        yield return new WaitForSeconds(timeInterval / 2);
    }
    */

    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.tag == "Conductor")
        {
            condName = colInfo.name;
            isConnected = true;
            SpawnEnergy();
        }

    }

    void OnTriggerExit2D(Collider2D colInfo)
    {
        if (colInfo.tag == "Conductor")
        {
            condName = colInfo.name;
            isConnected = false;
        }
    }
    /*void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (isConnected)
        {
            if(timer >= timeInterval)
            {
                SpawnEnergy();
                timer = 0f;
            }
        }        
    } */  

	void SpawnEnergy() {
		Rigidbody2D energyClone;
		Vector2 energySpawn = GameObject.Find(condName).transform.position + (distanceSpawn * GameObject.Find(condName).transform.up) ;
		energyClone = Instantiate(EnergyObj, energySpawn, Quaternion.identity);
		energyClone.velocity = GameObject.Find(condName).transform.up * speed;
		energyClone.rotation = GameObject.Find(condName).GetComponent<ConductorCreator>().rotation;
	}
}
