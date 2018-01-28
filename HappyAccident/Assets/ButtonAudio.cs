using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAudio : MonoBehaviour {

    void OnMouseUp()
    {
        AudioSource buttonAudio = GetComponent<AudioSource>();
        buttonAudio.Play();
    }
}
