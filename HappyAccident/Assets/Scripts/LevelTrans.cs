using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelTrans : MonoBehaviour {
	public float DelayTime = 10.0f;
	public string nextSceneName;
	bool goToNext = false;


	// Use this for initialization
	void Start () {
		StartCoroutine ("delayTime");
	}

	IEnumerator delayTime() {
		yield return new WaitForSeconds (DelayTime);
		goToNext = true;
	}
	// Update is called once per frame
	void Update () {
		if (Input.anyKeyDown) {
			goToNext = true;
		}
		if (goToNext) {
			SceneManager.LoadSceneAsync(nextSceneName);
		}
	}
}