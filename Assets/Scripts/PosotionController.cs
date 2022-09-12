using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosotionController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = pointA.position;

    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Vector2.Distance(transform.position, pointB.position));
         transform.Translate((pointB.position - pointA.position) * speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, pointB.position) < 0.1f)
        {
            transform.position = pointB.position;
        }
        // else
        // {
        //     transform.Translate((pointB.position - pointA.position) * speed * Time.deltaTime);
        // }
    }
}
