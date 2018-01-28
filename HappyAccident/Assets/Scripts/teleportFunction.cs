using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportFunction : MonoBehaviour
{
    public GameObject child;
    public float maxDistance = 3;

    public AudioSource teleporterAudio;
    public AudioSource grabAudio;
    public AudioSource dropAudio;

    void Update()
    {
        //distance for the child (P.S I do not know what these code are doing)
        float dst = Vector3.Distance(child.transform.position, transform.position);
        if (dst > maxDistance)
        {
            Vector3 vect = transform.position - child.transform.position;
            vect = vect.normalized;
            vect *= (dst - maxDistance);
            child.transform.position += vect;
        }
    }

    //Credit to EnergyCollide script
    void OnCollisionEnter2D(Collision2D collideInfo)
    {
        if (collideInfo.collider.tag == "Energy")
        {
            collideInfo.transform.position = child.transform.position;
            teleporterAudio.Play();
            //if (grabAudio.isPlaying || dropAudio.isPlaying)
            //{
            //    grabAudio.Stop();
            //    dropAudio.Stop();
            //    teleporterAudio.Play();
            //}
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
