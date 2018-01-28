using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScripts : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        AudioSource backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
        AudioSource backgroundMusic = GetComponent<AudioSource>();
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
        }
	}
}
