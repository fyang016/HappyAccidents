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
	void Start () {
        gameObject.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    GameObject tempConductor, tempTeleporter, tempDeactivator;
    void OnEnable()
    {
        Debug.Log("N");
        tempConductor = Instantiate(conductor, conduct.position + new Vector3(2, 0, -10), conduct.rotation );
        tempTeleporter = Instantiate(teleporter, teleport.position + new Vector3(2, 0, -10), teleport.rotation);
        tempDeactivator = Instantiate(deactivator, deactive.position + new Vector3(2, 0, -10), deactive.rotation);
        
    }
    void OnDisable()
    {
        //Destroy(tempConductor);
        //Destroy(tempTeleporter);
        
        Bounds cbounds = this.GetComponent<BoxCollider2D>().bounds;
        Bounds tbounds = cbounds;
        Bounds dbounds = cbounds;
        bool conductorIsInsideTheBox = cbounds.Contains(tempConductor.transform.position);
        bool teleporterIsInsideTheBox = tbounds.Contains(tempTeleporter.transform.position);
        bool deactivatorIsInsideTheBox = dbounds.Contains(tempDeactivator.transform.position);
        if (conductorIsInsideTheBox)
        {
            Destroy(tempConductor);
        }
        if (teleporterIsInsideTheBox)
        {
            Destroy(tempTeleporter);
        }
        if (deactivatorIsInsideTheBox)
        {
            Destroy(tempDeactivator);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exiting");
        GameObject c = collision.gameObject;
    }
}
