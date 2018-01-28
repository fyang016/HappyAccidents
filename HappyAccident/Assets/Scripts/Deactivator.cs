using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour {


	public ScaleWell gravityWell;

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			gravityWell.toggleWell ();
			Debug.Log ("Hitter");
            AudioSource deactivatorAudio = GetComponent<AudioSource>();
            deactivatorAudio.Play();
        }
	}
}
