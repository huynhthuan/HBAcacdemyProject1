using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam5 : MonoBehaviour
{
    public Transform car;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public float speed = 10;
    private bool isAtB = false;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (!isAtB)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointB.position,
                Time.deltaTime * speed
            );
        }
        else
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointA.position,
                Time.deltaTime * speed
            );
        }
    }
}
