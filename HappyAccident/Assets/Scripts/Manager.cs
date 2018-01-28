using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    // Use this for initialization
    public List<GameObject> components;
    public bool canMove = true;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    void Start () {
		
	}
    //Removes all parts
    public void RemoveAllParts()
    {
        foreach (GameObject items in components)
        {
            Destroy(items);
            components.RemoveAll(item => item == null);

        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
