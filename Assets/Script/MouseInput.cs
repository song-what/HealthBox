using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MouseInput : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            const float maxDistance = 100f;
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            //Debug.DrawRay(transform.position, ray, Color.green);
            RaycastHit[] hits = Physics.RaycastAll(ray, maxDistance).OrderBy(h => h.distance).ToArray();
            for (int i = 0; i < hits.Length; i++)
            {
                RaycastHit hit = hits[i];
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.transform.position = hit.transform.position;
                Destroy(sphere);

                if (hit.collider.gameObject.CompareTag("A"))
                {
                    // do something with this object
                    Debug.Log("A is selected");
                } else if(hit.collider.gameObject.tag =="A")
                {
                    Debug.Log("tag is A");
                } else
                {
                    Debug.Log("Nothing");
                }
            }
        }
    }
}
