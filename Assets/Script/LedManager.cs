using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedManager : MonoBehaviour
{
    public GameObject Led1;
    public GameObject Led2;
    public GameObject Led3;
    Renderer led1Renderer;
    Renderer led2Renderer;
    Renderer led3Renderer;
    Material OnMaterial1;
    Material OffMaterial1;
    Material OnMaterial2;
    Material OffMaterial2;
    Material OnMaterial3;
    Material OffMaterial3;

    Material[] materials1;
    Material[] materials2;
    Material[] materials3;

    public static bool touchMug;
    public static bool touchBox;



    // Start is called before the first frame update
    void Start()
    {
        led1Renderer = Led1.GetComponent<Renderer>();
        led2Renderer = Led2.GetComponent<Renderer>();
        led3Renderer = Led3.GetComponent<Renderer>();

        //120s
        InvokeRepeating("ExerciseReminder", 120, 120);

        //60s --> One minute
        InvokeRepeating("DrinkReminder", 60, 60);


    }

    // Update is called once per frame
    void Update()
    {
        if (PostureDetection.testModule)
        {
            PostureReminder();
            ExerciseDetector();
            DrinkDetector();
        }
    }

    void PostureReminder()
    {
        //Debug.Log("check pos: "+ PostureDetection.checkPos);

        led1Renderer.material.SetColor("_Color", new Color(0f, 0f, 0f));
        
        if (!PostureDetection.checkPos)
        {
            led1Renderer.material.SetColor("_Color", Color.red);
        } 
    }
    void ExerciseReminder()
    {
        led2Renderer.material.SetColor("_Color", Color.red);
    }

    void DrinkReminder()
    {
        //Debug.Log("One minute have passed");
        led3Renderer.material.SetColor("_Color", Color.red);
    }

    void ExerciseDetector()
    {
        if (touchBox)
        {
            led2Renderer.material.SetColor("_Color", new Color(0f, 0f, 0f));
            touchBox = false;
        }
    }

    void DrinkDetector()
    {
        if (touchMug)
        {
            led3Renderer.material.SetColor("_Color", new Color(0f, 0f, 0f));
            touchMug = false;
        }
    }



    /*public void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            //Material v = materials1[0];
            //materials1[0] = materials1[1];
            //materials1[1] = v;

            led1Renderer.material.SetColor("_Color", new Color(0f, 0f, 0f));
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            //Material v = materials1[1];
            //materials1[1] = materials1[0];
            //materials1[0] = v;

            led2Renderer.material.SetColor("_Color", Color.black);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            //do stuff
            led3Renderer.material.SetColor("_Color", Color.black);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            //do stuff
            led1Renderer.material.SetColor("_Color", Color.red);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            //do stuff
            led2Renderer.material.SetColor("_Color", Color.red);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            //do stuff
            led3Renderer.material.SetColor("_Color", Color.red);
        }
    }*/
}
