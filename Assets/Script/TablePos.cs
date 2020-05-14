using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablePos : MonoBehaviour
{
    public GameObject tableTracker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(tableTracker.transform.position.x, 0.88f, tableTracker.transform.position.z);

    }
}
