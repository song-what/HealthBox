using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustFoV : MonoBehaviour
{
    // Start is called before the first frame update
    float m_FieldOfView;

    void Start()
    {
        //Start the Camera field of view at 60
        m_FieldOfView = 180.0f;
    }

    void Update()
    {
        //Update the camera's field of view to be the variable returning from the Slider
        Camera.main.fieldOfView = m_FieldOfView;
    }

    void OnGUI()
    {
        //Set up the maximum and minimum values the Slider can return (you can change these)
        float max, min;
        max = 150.0f;
        min = 20.0f;
        //This Slider changes the field of view of the Camera between the minimum and maximum values
        m_FieldOfView = GUI.HorizontalSlider(new Rect(20, 20, 100, 40), m_FieldOfView, min, max);
    }
}
