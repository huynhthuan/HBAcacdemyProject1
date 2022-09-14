using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam12 : MonoBehaviour
{
    public Camera cameraMain;
    bool isCatchObject = false;
    private GameObject objectCatched;

    public Transform pointB;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, Vector3.forward);

            if (hit)
            {
                isCatchObject = true;
                objectCatched = hit.collider.gameObject;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            isCatchObject = false;
            objectCatched = null;
        }

        if (isCatchObject)
        {
            objectCatched.transform.position =
                cameraMain.ScreenToWorldPoint(Input.mousePosition) - cameraMain.transform.position;
        }

        if (
            objectCatched
            && Vector2.Distance(objectCatched.transform.position, pointB.position) < 0.1f
        )
        {
            Debug.Log("Complete");
        }
    }
}
