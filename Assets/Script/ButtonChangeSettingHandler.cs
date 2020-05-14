using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChangeSettingHandler : MonoBehaviour
{
    public GameObject Setting1stGroup;
    public GameObject Setting2rdGroup;


    // Update is called once per frame
    public void Go2rdSetting()
    {
        Setting1stGroup.SetActive(false);
        Setting2rdGroup.SetActive(true);
    }

    public void Go1stSetting()
    {
        Setting1stGroup.SetActive(true);
        Setting2rdGroup.SetActive(false);
    }
}
