using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPreHandler : MonoBehaviour
{
    public void GoPre()
    {
        if (EnglishTest.preQuestion == false)
        {
            EnglishTest.preQuestion = true;
            Debug.Log("pre question");
        }
    }
}
