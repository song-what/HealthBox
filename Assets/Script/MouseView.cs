using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseView : MonoBehaviour
{
    // Start is called before the first frame update
    public float ZValue = 5;
    public Camera camera;



    void Update()
    {
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ZValue);
        Vector3 cursorPosition = camera.ScreenToWorldPoint(cursorPoint);
        transform.position = cursorPosition;
        transform.LookAt(camera .transform);
    }
}
