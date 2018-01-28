using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conductorAudio : MonoBehaviour
{
    private float colliderFloat;

    public AudioSource conductAudio;
    public AudioSource grabAudio;
    public AudioSource dropAudio;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D colInfo)
    {
        if (colInfo.tag == "Energy")
        {
            //colliderFloat += 1;
            Debug.Log("colliderFloat");
            if(!conductAudio.isPlaying)
            {
                conductAudio.Play();
            }
        }
    }

    //void OnTriggerExit2D(Collider2D colliderExit)
    //{
    //    if (colliderExit.tag == "Energy")
    //    {
    //        colliderFloat -= 1;
    //        Debug.Log(colliderFloat);
    //        if (colliderFloat == 0)
    //        {
    //            conductAudio.Stop();
    //        }
    //    }
    //}

    void OnMouseDown()
    {
        grabAudio.Play();
    }

    void OnMouseUp()
    {
        dropAudio.Play();
    }
}
