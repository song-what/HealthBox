using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider collision)
    {
        //Debug.Log("Collision");

        if (collision.gameObject.tag == "mug")
        {
            //Debug.Log("Mug is selected");
            LedManager.touchMug = true;
        } else if (collision.gameObject.tag == "box")
        {
            //Debug.Log("Box is selected");
            LedManager.touchBox = true;
        }
    }
}
