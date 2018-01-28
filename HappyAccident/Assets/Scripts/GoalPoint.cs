using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GoalPoint : MonoBehaviour {
	public string nextSceneName;
	void Start() {
		
	}

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			AudioSource winSong = GetComponent<AudioSource> ();
			winSong.Play ();

			Debug.Log ("Help");
			SceneManager.LoadScene(nextSceneName);
		}
	}
}
