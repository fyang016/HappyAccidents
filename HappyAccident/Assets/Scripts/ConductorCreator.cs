using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConductorCreator : MonoBehaviour {
	public GameObject CondStart;
	public GameObject CondMid;
	public GameObject CondEnd;

	public GameObject CondContainer;
	public SpriteRenderer CondRender;
	public int numberOfConductor = 3;
	public int lowerCondLimit = 3;
	public int upperCondLimit = 6;

	public float numberToIncre = 1.0f;
    public AudioSource resizerAudio;

    public int rotation = 0;

    SpriteRenderer rend;

	[SerializeField] bool isSelected = false;
	bool createFirst = true;

	void start() {
		
	}

	void OnMouseDown() {
		isSelected = true;
		Debug.Log ("Hit");
		if (isSelected) {
			// CondRender.color = (Color.red);
		}
		else if (!isSelected) {
			CondRender.color = new Color(255,255,255);
		}
	}
	void OnMouseUp(){
		isSelected = false;
	}

	void FixedUpdate() {
		if (createFirst) {
			createCond (numberOfConductor, CondContainer);
			createFirst = false;
		}
		if (isSelected) {
			if (Input.GetKeyDown ("g")) {
				createCond (numberOfConductor, CondContainer);
			}
			else if (Input.GetKeyDown(KeyCode.Z)) {
				if (numberOfConductor < upperCondLimit) {
					numberOfConductor++;
					createCond (numberOfConductor, CondContainer);
				}
                //KingdomCross was here
                resizerAudio.Play();
            }
			else if (Input.GetKeyDown(KeyCode.X)) {
				if(numberOfConductor > lowerCondLimit) {
					numberOfConductor--;
				    createCond (numberOfConductor, CondContainer);
				}
                resizerAudio.Play();
            }
			/*if (Input.GetKeyDown(KeyCode.Space))
			{
                Debug.Log("space");
                rotation = rotation + 90;
                if (rotation >= 360)
                {
                    rotation = 0;
                }
				transform.Rotate(0, 0, 90);
			}*/
		}
	}

	void createCond(int numParts, GameObject CondContainer) {
		foreach (Transform child in transform) {
			GameObject.Destroy (child.gameObject);
		}
        Debug.Log(CondContainer.transform.position);
		for (int i = 1; i < numParts; i++) {
			Vector2 newPos = CondContainer.transform.position + (CondContainer.transform.up * i * numberToIncre);
			if (i == 0) {
				Instantiate(CondStart, newPos, CondContainer.transform.rotation, CondContainer.transform);
			} else if (i == numParts - 1) {
				Instantiate(CondEnd, newPos, CondContainer.transform.rotation, CondContainer.transform);
			} else {
				Instantiate(CondMid, newPos, CondContainer.transform.rotation, CondContainer.transform);
			}

		}
	}
}

