using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaliTrackers : MonoBehaviour
{

    public GameObject trackerTable;
    public GameObject markInVR;
    public GameObject mug;
    public GameObject trackerMug;
    public GameObject trackerHand;
    public GameObject caliSphere;

    Vector3 diff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff = trackerHand.transform.position - trackerTable.transform.position;
        //Debug.Log(diff.ToString("F2"));

        caliSphere.transform.position = trackerTable.transform.position ;
        //mug.transform.position = trackerMug.transform.position + diff;
        
    }
}
