using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMove : MonoBehaviour {

    [SerializeField]
    float speed = 10;
	int degree = 90;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(x, y, 0);
    }
    void OnMouseDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        // Debug.Log(distance_to_screen);
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        //Debug.Log(pos_move);
        transform.position = new Vector3(pos_move.x, pos_move.y, pos_move.z);
		if (Input.GetKeyDown(KeyCode.Space))
		{
			transform.Rotate(0, 0, degree);
		}
		transform.position = new Vector3 (Mathf.Round (transform.position.x),
			Mathf.Round (transform.position.y),
			Mathf.Round (transform.position.z));
	}

}
