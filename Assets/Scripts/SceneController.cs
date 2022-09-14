using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public Camera cameraMain;
    bool isCatchObject = false;
    private GameObject objectCatched;

    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public Transform pointE;
    public Transform car;
    Rigidbody2D rb;
    Vector3 target;

    Transform[] listPoint;

    bool isReturn = true;
    Transform randomPoint;

    Vector3 oldPosition;


    // Start is called before the first frame update
    void Start()
    {
        rb = car.GetComponent<Rigidbody2D>();
        listPoint = new Transform[] { pointA, pointB, pointC, pointD, pointE };
        oldPosition = car.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        // Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);

        // Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        // Debug.DrawRay(ray.origin, forward, Color.green);

        //Exam 11
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit2D hit = Physics2D.Raycast(ray.origin, Vector3.forward);

        //     if (hit)
        //     {
        //         Debug.Log(hit);
        //         hit.transform.GetComponent<SpriteRenderer>().color = Color.black;
        //     }
        //     else
        //     {
        //         Debug.Log("no hit");
        //         Debug.Log(ray);
        //     }
        // }

        //Exam 12
        // if (Input.GetMouseButtonDown(0))
        // {
        //     Ray ray = cameraMain.ScreenPointToRay(Input.mousePosition);
        //     RaycastHit2D hit = Physics2D.Raycast(ray.origin, Vector3.forward);

        //     if (hit)
        //     {
        //         isCatchObject = true;
        //         objectCatched = hit.collider.gameObject;
        //     }
        // }

        // if (Input.GetMouseButtonUp(0))
        // {
        //     isCatchObject = false;
        //     objectCatched = null;
        // }

        // if (isCatchObject)
        // {
        //     objectCatched.transform.position = cameraMain.ScreenToWorldPoint(Input.mousePosition) - cameraMain.transform.position;
        // }

        // if (objectCatched && Vector2.Distance(objectCatched.transform.position, pointB.position) < 0.1f)
        // {
        //     Debug.Log("Complete");
        // }

        // Exe3

        // if (Input.GetMouseButtonDown(0))
        // {
        //     target = cameraMain.ScreenToWorldPoint(Input.mousePosition);
        //     rb.velocity = (target - car.transform.position) * 50 * Time.deltaTime;
        // }

        // if (Vector2.Distance(car.transform.position, target) < 0.01f)
        // {
        //     car.transform.position = target - cameraMain.transform.position;
        // }

        //Exe4

        // if (isReturn)
        // {
        //     randomPoint = listPoint[Random.Range(0, 5)];
        //     isReturn = false;
        // }

        // car.transform.position = Vector3.MoveTowards(car.transform.position, randomPoint.position, Time.deltaTime * 10);

        // if (Vector2.Distance(car.transform.position, randomPoint.position) < 0.01f)
        // {
        //     car.transform.position = oldPosition;
        //     isReturn = true;
        // }

    }
}
