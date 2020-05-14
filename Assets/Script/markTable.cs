using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class markTable : MonoBehaviour
{
    public GameObject trackerTable;
    public GameObject markInVR;
    Vector3 diff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        diff = markInVR.transform.position - trackerTable.transform.position;
        gameObject.transform.position = trackerTable.transform.position + diff;
    }
}
