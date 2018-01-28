using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class GoalPoint : MonoBehaviour {
	private AssetBundle myLoadedAssetBundle;
	private string[] scenePaths;
	void Start() {
		myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
		scenePaths = myLoadedAssetBundle.GetAllScenePaths();
	}

	void OnTriggerEnter2D(Collider2D colInfo) {
		if (colInfo.tag == "Energy") {
			AudioSource winSong = GetComponent<AudioSource> ();
			winSong.Play ();
			int nextSceneIndex = SceneManager.GetActiveScene ().buildIndex + 1;
			Debug.Log ("Help");
			if (SceneManager.sceneCount > nextSceneIndex) {

				SceneManager.LoadSceneAsync (nextSceneIndex);
			}
		}
	}
}
