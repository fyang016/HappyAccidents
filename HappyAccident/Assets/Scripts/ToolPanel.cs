using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolPanel : MonoBehaviour {


    // Use this for initialization
    [SerializeField]
    GameObject conductor;
    [SerializeField]
    Transform conduct, teleport;
    [SerializeField]
    GameObject teleporter;
    List<GameObject> activeItems;
    public bool isActive = false;
	void Start () {
        gameObject.SetActive(isActive);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    GameObject tempConductor;
    GameObject tempTeleporter;
    void OnEnable()
    {
        Debug.Log("N");
        tempConductor = Instantiate(conductor, conduct.position + new Vector3(1, 0, 0), conduct.rotation );
        tempTeleporter = Instantiate(teleporter, teleport.position + new Vector3(1, 0, 0), teleport.rotation);

    }
    void OnDisable()
    {
        //Destroy(tempConductor);
        //Destroy(tempTeleporter);
        
        Bounds cbounds = this.GetComponent<BoxCollider2D>().bounds;
        Bounds tbounds = cbounds;
        bool conductorIsInsideTheBox = cbounds.Contains(tempConductor.transform.position);
        bool teleporterIsInsideTheBox = tbounds.Contains(tempTeleporter.transform.position);
        if (conductorIsInsideTheBox)
        {
            Destroy(tempConductor);
        }
        if (teleporterIsInsideTheBox)
        {
            Destroy(tempTeleporter);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exiting");
        GameObject c = collision.gameObject;
    }
}
