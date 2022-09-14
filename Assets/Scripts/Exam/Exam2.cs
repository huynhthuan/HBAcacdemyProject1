using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam2 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform car;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        {
            car.transform.position = pointA.position;
        }
    }
}
