using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportFunction : MonoBehaviour
{
    [SerializeField]
    GameObject child;
    public float distance = 3;

    void Update()
    {
        //distance for the child (P.S I do not know what these code are doing)
        float dst = Vector3.Distance(child.transform.position, transform.position);
        if (dst > distance)
        {
            Vector3 vect = transform.position - child.transform.position;
            vect = vect.normalized;
            vect *= (dst - distance);
            child.transform.position += vect;
        }
    }

    //Credit to EnergyCollide script
    void OnCollisionEnter2D(Collision2D collideInfo)
    {
        if (collideInfo.collider.tag == "Energy")
        {
            collideInfo.transform.position = child.transform.position;
        }
    }

    //Credit to EmitterEnergy script (Jim)
    //void OnMouseDrag()
    //{
    //    float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    //    Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
    //    transform.position = new Vector3(pos_move.x, pos_move.y, pos_move.z);
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        transform.Rotate(0, 0, 90);
    //    }

    //}
}
