using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToScene : MonoBehaviour {
	public string nextSceneName;

	public void LoadLevel(string nextSceneName) {
		Debug.Log ("Load level");
		SceneManager.LoadScene(nextSceneName);
	}
}
