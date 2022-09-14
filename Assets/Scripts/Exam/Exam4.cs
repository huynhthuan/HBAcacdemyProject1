using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam4 : MonoBehaviour
{
    public Transform car;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public float time = 0;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        car.transform.position = Vector3.Slerp(
            pointA.position,
            pointB.position,
            time / Vector2.Distance(car.position, pointC.position)
        );
        time += Time.deltaTime;
    }
}
