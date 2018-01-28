using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour {

    // Use this for initialization
    GameObject gamemanager;
	void Start () {
        gamemanager = GameObject.Find("_GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamemanager.GetComponent<Manager>().components.Add(collision.gameObject);
    }
}
