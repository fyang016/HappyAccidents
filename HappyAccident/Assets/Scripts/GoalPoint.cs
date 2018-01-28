using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class GoalPoint : MonoBehaviour {
	public string nextSceneName;
	[SerializeField] bool isFinished = false;
	public Canvas newText;
	public string winString;
	void Start() {
		
	}

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			AudioSource winSong = GetComponent<AudioSource> ();
			winSong.Play ();
			Debug.Log ("Energy");
			isFinished = true;
			Canvas item = Instantiate(newText, new Vector3 (0,0,0), transform.rotation) as Canvas;

		}
	}

	void FixedUpdate() {
		if (isFinished) {
			if(Input.GetKeyDown(KeyCode.Space)) {
			    SceneManager.LoadScene(nextSceneName);
			}
		}
	}
}
