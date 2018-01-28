using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    //[RequireComponent(typeof(AudioSource))]
public class gravityWellAudio : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collideInfo)
    {
        if (collideInfo.collider.tag == "Energy")
        {
            AudioSource gravityAudio = GetComponent<AudioSource>();
            gravityAudio.Play();
        }
    }
}
