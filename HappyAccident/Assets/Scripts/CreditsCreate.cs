using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsCreate : MonoBehaviour {

	public string[] arrayCredits;
	public Rigidbody2D parent;
	public float spaceVertBetween = 16.0f;
	public Text newText;
	void Start () {
		
		for (int i = 0; i < arrayCredits.Length; i++) {
			Vector2 movePos = new Vector3 (0,-1 * i * spaceVertBetween,0) + parent.transform.position;
			Text item = Instantiate(newText, movePos, parent.transform.rotation, parent.transform) as Text;
			item.text = arrayCredits[i];
			item.transform.position = movePos;
		}
	}
	
	// Update is called once per frame

}
