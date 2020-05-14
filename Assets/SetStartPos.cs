using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;


public class SetStartPos : MonoBehaviour
{
    public SteamVR_Action_Vector2 actionMove = SteamVR_Input.GetAction<SteamVR_Action_Vector2>("default", "Move");

    private void Update()
    {
        
    }
}