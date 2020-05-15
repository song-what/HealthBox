using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonConfirmHandler : MonoBehaviour
{
    public GameObject quizGroup;
    public GameObject settingGroup;
    public GameObject startButton;
    public void SettingPosConfirm()
    {
        if (PostureDetection.setPosture == false)
        {
            PostureDetection.setPosture = true;
            //settingGroup.SetActive(false);
            //quizGroup.SetActive(true);
            startButton.SetActive(true);
        }
    }
}

