using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{   

    public bool clickPre;
    public bool clickNext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetClickPre(bool flag)
    {
        clickPre = flag; 
    }

    public bool GetClickPre()
    {
        return clickPre;
    }

    public void SetClickNext(bool flag)
    {
        clickNext = flag;
    }

    public bool GetClickNext()
    {
        return clickNext;
    }
}
