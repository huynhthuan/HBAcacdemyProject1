using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosotionController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public Rigidbody2D rb;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA.position;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = (pointB.position - pointA.position) * speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, pointB.position) < 0.1f)
        {
            transform.position = pointA.position;
        }

        // transform.Translate((pointB.position - pointA.position) * speed * Time.deltaTime);

        // transform.position = Vector3.MoveTowards(transform.position, pointB.position, Time.deltaTime * speed);


    }
}
