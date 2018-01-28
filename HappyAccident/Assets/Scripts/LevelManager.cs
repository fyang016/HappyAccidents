using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {
	private AssetBundle myLoadedAssetBundle;
	private string[] scenePaths;
	// Use this for initialization
	void Start()
	{
		myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
		scenePaths = myLoadedAssetBundle.GetAllScenePaths();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
