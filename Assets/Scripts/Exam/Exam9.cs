using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam9 : MonoBehaviour
{
    public Transform car;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public float time = 0;
    public float rate = 2f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        time += 1 / rate * Time.deltaTime;
        car.transform.position = Vector3.Lerp(pointA.position, pointB.position, time);

        if (time >= 1)
        {
            time = 0;
            car.transform.position = pointA.position;
        }
    }
}
