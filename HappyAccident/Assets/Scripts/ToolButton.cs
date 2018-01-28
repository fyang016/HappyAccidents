using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolButton : MonoBehaviour {
    [SerializeField]
    GameObject panel, pause;
    
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = panel.GetComponent<Animator>();
        anim.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
        Debug.Log("HI");
        
        if (panel.GetComponent<ToolPanel>().isActive)
        {
            
            //anim.enabled = true;
            //play the Slidein animation
            //anim.Play("PanelSlideOut");
            panel.gameObject.SetActive(false);
            panel.GetComponent<ToolPanel>().isActive = false;
        }
        else
        {
            panel.SetActive(true);
            
            //play the Slidein animation
            //anim.Play("PanelSlide");
            panel.gameObject.SetActive(true);
            panel.GetComponent<ToolPanel>().isActive = true;
        }
    }
    public void Pause()
    {
        if(pause.gameObject.activeSelf)
        {
            pause.gameObject.SetActive(false);
        }
        else
        {
            pause.gameObject.SetActive(true);
        }
        
    }
}
