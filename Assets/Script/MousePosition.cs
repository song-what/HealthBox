using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    Vector3 realMousePos;
    //Vector3 virtualMousePos;
    public GameObject mouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 virtualMousePos = new Vector3(Input.mousePosition.x / 10000f+0.05f, 0.8288574f, Input.mousePosition.y / 10000f -0.12f );
        mouse.transform.position = virtualMousePos;

        //debug.log("real" + input.mouseposition.tostring());
        //Debug.Log("virtual"+ virtualMousePos.ToString());
    }
}
