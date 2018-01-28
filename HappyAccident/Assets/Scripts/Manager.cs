using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    // Use this for initialization
<<<<<<< HEAD
    public List<GameObject> components;
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
=======
    GameObject[] components;
   
>>>>>>> 2be8bccccfba7231472cc862696657b81fd7f699
}
