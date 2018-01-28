using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleBlockAudio : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D colInfo)
    {
        if (colInfo.collider.tag == "Energy")
        {
            AudioSource simpleAudio = GetComponent<AudioSource>();
            simpleAudio.Play();
        }
    }
}
