using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolPanel : MonoBehaviour {


    // Use this for initialization
    [SerializeField]
    GameObject conductor, teleporter, deactivator;
    [SerializeField]
    Transform conduct, teleport, deactive;
    List<GameObject> activeItems;
    public bool isActive = false;
    GameObject manager;
	void Start () {
        //gameObject.SetActive(isActive);
        manager = GameObject.Find("_GameManager");
	}

    // Update is called once per frame
    bool enable = true;
    
	void Update () {
		
	}
    GameObject tempConductor, tempTeleporter, tempDeactivator;
    void OnEnable()
    {
        Debug.Log("N");
        tempConductor = Instantiate(conductor, conduct.position + new Vector3(0,0, -1) , conduct.rotation );
        tempTeleporter = Instantiate(teleporter, teleport.position + new Vector3(0, 0, -1), teleport.rotation);
        tempDeactivator = Instantiate(deactivator, deactive.position + new Vector3(0, 0, -1), deactive.rotation);
        
    }
    void OnDisable()
    {
        //Destroy(tempConductor);
        //Destroy(tempTeleporter);
        
        Bounds bounds = this.GetComponent<BoxCollider>().bounds;
        bool conductorIsInsideTheBox = bounds.Contains(tempConductor.transform.position);
        bool teleporterIsInsideTheBox = bounds.Contains(tempTeleporter.transform.position);
        bool deactivatorIsInsideTheBox = bounds.Contains(tempDeactivator.transform.position);
        if (conductorIsInsideTheBox)
        {
            Destroy(tempConductor);
        }
        else { manager.GetComponent<Manager>().components.Add(tempConductor); }
        if (teleporterIsInsideTheBox)
        {
            Destroy(tempTeleporter);
        }
        else { manager.GetComponent<Manager>().components.Add(tempTeleporter); }
        if (deactivatorIsInsideTheBox)
        {
            Destroy(tempDeactivator);
        }
        else { manager.GetComponent<Manager>().components.Add(tempDeactivator); }


    }
    private void OnTriggerExit(Collider collision)
    {
        Debug.Log("Exiting");
        GameObject c = collision.gameObject;
        
    }
}
