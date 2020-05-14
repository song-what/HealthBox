using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugFuc : MonoBehaviour
{
    CharacterController controller;


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
        Debug.Log("Collision");
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log("Controller Collision");
    }

    

}
