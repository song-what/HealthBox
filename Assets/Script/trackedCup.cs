using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackedCup : MonoBehaviour
{

    public GameObject tracker;
    public GameObject tableTracker;
    public GameObject tableSurface;
    Vector3 trackerPos;
    Vector3 cupPos;
    float diff;
    // Start is called before the first frame update
    void Start()
    {
        diff = tableTracker.transform.position.z - tableSurface.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        trackerPos = tracker.transform.position;
        cupPos = new Vector3(trackerPos.x, trackerPos.y -0.05f, trackerPos.z  );
        gameObject.transform.position = cupPos;
    }
}
