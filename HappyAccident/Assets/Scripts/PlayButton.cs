using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    GameObject Emitter;
    GameObject manager;
    EmitterEnergy e;
	void Start () {
        Emitter = GameObject.Find("Emitter");
        e = Emitter.GetComponent<EmitterEnergy>();
        manager = GameObject.Find("_GameManager");
    }
	public void onclick()
    {
        if (Emitter.GetComponent<EmitterEnergy>().isEmitting)
        {
            e.isEmitting = false;
            manager.GetComponent<Manager>().canMove = false;
        }
        else
        {
            e.isEmitting = true;
            manager.GetComponent<Manager>().canMove = false;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
