﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class VRController : MonoBehaviour
{
    public float m_Sensitivty = 0.1f;
    public float m_MaxSpeed = 1.0f;

    public SteamVR_Action_Boolean m_MovePress = null;
    public SteamVR_Action_Vector2 m_MaxValue = null;

    private float m_Speed = 0.0f;

    private CharacterController m_CharacterController = null;
    private Transform m_CameraRig = null;
    private Transform m_Head = null;

    public GameObject CameraRig;
    public GameObject Camera;

    public void Awake()
    {
        m_CharacterController = GetComponent<CharacterController>();
    }
    void Start()
    {
        m_CameraRig = CameraRig.transform;
        m_Head = Camera.transform;

    }

    void Update()
    {
        HandleHead();
        CalculateMovement();
        HandleHeight();
    }

    private void HandleHead()
    {
        //Store current
        Vector3 oldPosition = m_CameraRig.position;
        Quaternion oldRotation = m_CameraRig.rotation;

        //Rotate
        transform.eulerAngles = new Vector3(0.0f, m_Head.rotation.eulerAngles.y, 0.0f);

        //Restore
        m_CameraRig.position = oldPosition;
        m_CameraRig.rotation = oldRotation;

    }

    private void CalculateMovement()
    {

    }

    private void HandleHeight()
    {

    }
}
