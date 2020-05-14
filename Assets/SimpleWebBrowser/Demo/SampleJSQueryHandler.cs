using UnityEngine;
using System.Collections;
using SimpleWebBrowser;

public class SampleJSQueryHandler : MonoBehaviour {

    public WebBrowser MainBrowser;
    public static bool transQueryClickA;
    public static bool transQueryClickB;
    public static bool transQueryClickC;
    public static bool transQueryClickD;
    public static bool transQueryClickPre;
    public static bool transQueryClickNext;
    string clickA;
    string clickB;
    string clickC;
    string clickD;
    string clickPre;
    string clickNext;
    string stopClickNext;
    //public GameObject clickManager;


    void Start()
    {
        MainBrowser.OnJSQuery += MainBrowser_OnJSQuery;
        clickA = "document.getElementById('A').click()";
        clickB = "document.getElementById('B').click()";
        clickC = "document.getElementById('C').click()";
        clickD = "document.getElementById('D').click()";
        clickPre = "document.getElementById('pre').click()";
        clickNext = "document.getElementById('next').click()";

    }

    private void MainBrowser_OnJSQuery(string query)
    {
        Debug.Log("Javascript query:" + query);
        
        MainBrowser.RespondToJSQuery("My response: OK");
    }

    private void TransClickQuery()
    {
        if(transQueryClickA)
        {
            Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickA);
            MainBrowser.RunJavaScript(clickA);

            transQueryClickA = false;
        }

        if (transQueryClickB)
        {
            Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickB);
            MainBrowser.RunJavaScript(clickB);

            transQueryClickB = false;
        }

        if (transQueryClickC)
        {
            Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickC);
            MainBrowser.RunJavaScript(clickC);

            transQueryClickC = false;
        }

        if (transQueryClickD)
        {
            Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickD);
            MainBrowser.RunJavaScript(clickD);

            transQueryClickD = false;
        }
        if (transQueryClickPre)
        {
            transQueryClickPre = false;
            Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickPre);
            MainBrowser.RunJavaScript(clickPre);
        }
        if (transQueryClickNext)
        {

            //Debug.Log("start click");
            //MainBrowser_OnJSQuery(clickNext);

            Debug.Log("next pls");
            MainBrowser.RunJavaScript(clickNext);
            transQueryClickNext = false;


        }
    }

    private void Update()
    {
        TransClickQuery();
       // transQueryClickNext = clickManager.GetComponent<ClickManager>().GetClickNext();
    }
}
