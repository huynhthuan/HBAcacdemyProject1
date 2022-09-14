using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exe4 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform pointD;
    public Transform pointE;
    bool isReturn = true;
    Transform randomPoint;
    Vector3 oldPosition;
    Transform[] listPoint;
    public Transform car;

    // Start is called before the first frame update
    void Start()
    {
        listPoint = new Transform[] { pointA, pointB, pointC, pointD, pointE };
    }

    // Update is called once per frame
    void Update()
    {
        if (isReturn)
        {
            randomPoint = listPoint[Random.Range(0, 5)];
            isReturn = false;
        }

        car.transform.position = Vector3.MoveTowards(
            car.transform.position,
            randomPoint.position,
            Time.deltaTime * 10
        );

        if (Vector2.Distance(car.transform.position, randomPoint.position) < 0.01f)
        {
            car.transform.position = oldPosition;
            isReturn = true;
        }
    }
}
