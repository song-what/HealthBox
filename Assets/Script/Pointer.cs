﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pointer : MonoBehaviour
{
    public float m_DefaultLength = 5.0f;
    public GameObject m_Dot;
    //public GameObject controller;
    public VRInputModule m_InputModule;

    private LineRenderer m_LineRenderer = null;


    private void Awake()
    {
        m_LineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateLine();
    }

    private void UpdateLine()
    {


        //Use default or distance
        PointerEventData data = m_InputModule.GetData();
        //float targetlength = m_DefaultLength;
        float targetlength = data.pointerCurrentRaycast.distance ==0 ? m_DefaultLength : data.pointerCurrentRaycast.distance;

        //Raycast
        RaycastHit hit = CreateRaycast(targetlength);

        //Default
        Vector3 endPosition = this.transform.position + (this.transform.forward * targetlength);

        //Or base on hit
        if(hit.collider != null)
        {
            endPosition = hit.point;
        }


        //Set position of the dot
        m_Dot.transform.position = endPosition;

        //Set linerenderer
        m_LineRenderer.SetPosition(0, this.transform.position);
        m_LineRenderer.SetPosition(1, endPosition);

    }

    private RaycastHit CreateRaycast(float length)
    {
        RaycastHit hit;

        Ray ray = new Ray(this.transform.position, this.transform.forward);
        Physics.Raycast(ray, out hit, m_DefaultLength);

        return hit;
    }
}
