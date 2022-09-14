using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam3 : MonoBehaviour
{
    public Transform car;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    private bool isAtA = true;
    private bool isAtB = false;
    private bool isAtC = false;
    public float speed;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (isAtA)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointB.position,
                Time.deltaTime * speed
            );
        }

        if (isAtB)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointC.position,
                Time.deltaTime * speed
            );
        }

        if (isAtC)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointA.position,
                Time.deltaTime * speed
            );
        }

        if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        {
            isAtA = false;
            isAtB = true;
        }

        if (Vector2.Distance(car.position, pointC.position) < 0.1f)
        {
            isAtB = false;
            isAtC = true;
        }

        if (Vector2.Distance(car.position, pointA.position) < 0.1f)
        {
            isAtC = false;
            isAtA = true;
        }
    }
}
