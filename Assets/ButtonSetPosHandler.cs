using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSetPosHandler : MonoBehaviour
{
    //public GameObject quizGroup;
    public GameObject settingGroup;
    public GameObject CameraRig;
    static int rotateDegree;
    void Start()
    {

        rotateDegree =0;
    }
    public void GoUp()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x , CameraRig.transform.position.y + 0.05f, CameraRig.transform.position.z);
    }
     public void GoDown()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x, CameraRig.transform.position.y - 0.05f, CameraRig.transform.position.z);
    }
     public void GoLeft()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x - 0.05f, CameraRig.transform.position.y, CameraRig.transform.position.z);
    }

    public void GoRight()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x + 0.05f, CameraRig.transform.position.y, CameraRig.transform.position.z);

    }

    public void GoFront()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x , CameraRig.transform.position.y, CameraRig.transform.position.z + 0.05f);

    }

    public void GoBack()
    {
        CameraRig.transform.position = new Vector3(CameraRig.transform.position.x, CameraRig.transform.position.y, CameraRig.transform.position.z - 0.05f);

    }

    public void RotateLeft()
    {
        rotateDegree = rotateDegree - 10;
        CameraRig.transform.localRotation = Quaternion.Euler(0, rotateDegree, 0);
        //CameraRig.transform.Rotate(new Vector3(0, -90, 0));
        Debug.Log("Press rotate key");
        Debug.Log("degree " + rotateDegree);
    }

    public void RotateRightt()
    {
        rotateDegree = rotateDegree +10;
        CameraRig.transform.localRotation = Quaternion.Euler(0, rotateDegree, 0);
        //CameraRig.transform.Rotate(new Vector3(0, -90, 0));
        Debug.Log("degree " + rotateDegree);

    }
}
