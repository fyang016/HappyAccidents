using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivator : MonoBehaviour {

	public ScaleWell gravityWell;

    public AudioSource deactivatorAudio;
    public AudioSource grabAudio;
    public AudioSource dropAudio;

    void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			gravityWell.toggleWell ();
			Debug.Log ("Hitter");
            deactivatorAudio.Play();
        }
	}

    void OnMouseDown()
    {
        grabAudio.Play();
    }

    void OnMouseUp()
    {
        dropAudio.Play();
    }
}
