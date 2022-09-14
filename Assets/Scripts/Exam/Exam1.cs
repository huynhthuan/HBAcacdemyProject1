using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam1 : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public float speed;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((pointB.position - pointA.position) * speed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(
            transform.position,
            pointB.position,
            Time.deltaTime * speed
        );
    }
}
