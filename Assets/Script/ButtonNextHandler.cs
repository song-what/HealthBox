using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNextHandler : MonoBehaviour
{
    
    public void GoNext()
    {
        if(EnglishTest.nextQuestion==false)
        {
            EnglishTest.nextQuestion = true;
            //Debug.Log("next question");
        }
    }
}
