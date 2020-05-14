using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handPos : MonoBehaviour
{
    public GameObject handTracker;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(handTracker.transform.position.x +0.15f, handTracker.transform.position.y-0.05f, handTracker.transform.position.z+0.025f );
        //gameObject.transform.position = new Vector3(handTracker.transform.position.x + 0.212f, 0.88f, handTracker.transform.position.z - 0.56f);
    }
}
