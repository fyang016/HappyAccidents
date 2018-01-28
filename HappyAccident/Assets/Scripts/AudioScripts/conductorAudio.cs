using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductorAudio : MonoBehaviour
{
    private float colliderFloat;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.tag == "Energy")
        {
            colliderFloat += 1;
            //Debug.Log(colliderFloat);
            AudioSource conductorAudio = GetComponent<AudioSource>();
            conductorAudio.Play();
        }
    }

    void OnTriggerExit2D(Collider2D colliderExit)
    {
        if (colliderExit.tag == "Energy")
        {
            colliderFloat -= 1;
            //Debug.Log(colliderFloat);
            if (colliderFloat == 0)
            {
                AudioSource conductorAudio = GetComponent<AudioSource>();
                conductorAudio.Stop();
            }
        }
    }
}
