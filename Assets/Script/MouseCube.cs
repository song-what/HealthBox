using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCube : MonoBehaviour
{
    public GameObject cursor;
    public GameObject child;
    Component childRender;
    public GameObject clickManager;
    bool sendNext;
    int timer;

    // Start is called before the first frame update
    void Start()
    {   
        
        childRender = child.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(Input.mousePosition.x/1000f-0.3f, Input.mousePosition.y/1000f +0.8f , 0.059f);
       

        cursor.transform.position = pos;
        child.transform.position = new Vector3(pos.x, pos.y, 0.0748f);
        //Debug.Log("Real"+ Input.mousePosition.ToString());
        //Debug.Log(pos.ToString("F3"));

        if (pos.x >= -0.144 && pos.x <= 0.5 && pos.y >= 0.972 && pos.y <= 1.326)
        {
            cursor.GetComponent<Renderer>().enabled = true;
            child.GetComponent<Renderer>().enabled = true;


        }
        else
        {
            cursor.GetComponent<Renderer>().enabled = false;
            child.GetComponent<Renderer>().enabled = false;
        }

        if (Input.GetMouseButtonUp(0))
        {
           // Debug.Log("Click");
           // clickMark = true;
        }

        /*timer++;

        if(sendNext && timer > 120)
        {
            clickManager.GetComponent<ClickManager>().SetClickNext(true);
            Debug.Log("next is selected");
            timer = 0;
        }*/
    }

    void OnTriggerStay(Collider collision)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "A")
        {
            if (Input.GetMouseButtonUp(0))
            {
                SampleJSQueryHandler.transQueryClickA = true;
                Debug.Log("A is selected");
            }

        }
        else if (collision.gameObject.tag == "B")
        {
            if (Input.GetMouseButtonUp(0))
            {
                SampleJSQueryHandler.transQueryClickB = true;
                Debug.Log("B is selected");
            }
                
        }
        else if (collision.gameObject.tag == "C")
        {
            if (Input.GetMouseButtonUp(0))
            {
                SampleJSQueryHandler.transQueryClickC = true;
                Debug.Log("C is selected");
            }
        }
        else if (collision.gameObject.tag == "D")
        {

            if (Input.GetMouseButtonUp(0))
            {
                SampleJSQueryHandler.transQueryClickD = true;
                Debug.Log("D is selected");
            }
        }
        else if (collision.gameObject.tag == "pre")
        {

            if (Input.GetMouseButtonUp(0))
            {   
                SampleJSQueryHandler.transQueryClickPre = true;
                Debug.Log("pre is selected");
            }
        }
        else if (collision.gameObject.tag == "next")
        {
            if (Input.GetMouseButtonUp(0))
            {
                SampleJSQueryHandler.transQueryClickNext = true;
                Debug.Log("next is selected");
            }

            //if (Input.GetMouseButton(0))
            //{
              //  sendNext = true;
            //}
        }
        

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Do something else here");
        }
    }
}
