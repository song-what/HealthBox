using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostureDetection : MonoBehaviour
{

    public static bool setPosture;
    public static Vector3 standardPos;
    public static bool checkPos;
    public static bool testModule; // set module or test module
    public Camera hmd;
    public GameObject positionBall;

    //List<GameObject> myObjects = new List<GameObject>();



    // Start is called before the first frame update
    void Start()
    {
        //myObjects = new List<GameObject>();

    }

    // Update is called once per frame
    void Update()
    {
        if(setPosture)
        {
            setPosture = false;
            testModule = true;
           
            positionBall.transform.position = hmd.transform.position;
        }

        //CheckPosture();
    }


    public void CheckPosture()
    {
        if(testModule && !checkPos)
        {
            //Debug.Log("Warning! Move!");
        }
    }

    void OnTriggerStay(Collider collision)
    {
        if (testModule)
        {

            if (collision.gameObject.tag == "hmdSphere")
            {
               checkPos = true;
               //Debug.Log("Collision");
            }
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        checkPos = false;
    }


}


