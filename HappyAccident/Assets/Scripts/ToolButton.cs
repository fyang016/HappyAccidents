using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolButton : MonoBehaviour {
    [SerializeField]
    GameObject panel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        Debug.Log("HI");
        if (panel.GetComponent<ToolPanel>().isActive)
        {
            panel.SetActive(false);
            panel.GetComponent<ToolPanel>().isActive = false;
        }
        else
        {
            panel.SetActive(true);
            panel.GetComponent<ToolPanel>().isActive = true;
        }
    }
}
