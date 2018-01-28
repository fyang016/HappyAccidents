using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditButtonToScene : MonoBehaviour {
	public string nextSceneName;

	public void LoadLevel() {
		Debug.Log ("Load level");
		SceneManager.LoadScene(nextSceneName);
	}
}
