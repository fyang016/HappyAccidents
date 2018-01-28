using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    GameObject Emitter;
    EmitterEnergy e;
	void Start () {
        Emitter = GameObject.Find("Emitter");
        e = Emitter.GetComponent<EmitterEnergy>();
	}
	public void onclick()
    {
        if (Emitter.GetComponent<EmitterEnergy>().isEmitting)
        {
            e.isEmitting = false;
        }
        else
        {
            e.isEmitting = true;
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
