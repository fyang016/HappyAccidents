using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(AudioSource))]
public class gravityWellAudio : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D collideInfo)
    {
        if (collideInfo.collider.tag == "Energy")
        {
            AudioSource gravityAudio = GetComponent<AudioSource>();
            gravityAudio.Play();
        }
    }
}
