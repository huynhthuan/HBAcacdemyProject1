using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosotionController : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public Transform car;
    private Rigidbody2D rb;
    public float speed;
    private bool isAtB = false;
    // private float lerpPct = 0.0f;
    Vector3 centerPoint;
    float distant;
    float posX;
    float posY;
    float duration = 1f;
    float rate = 0;
    // float time = 0;
    // float timeDelay = 0;
    // bool isCanReturn = false;

    // Start is called before the first frame update
    void Start()
    {
        // car.transform.position = pointA.position;
        rb = car.gameObject.GetComponent<Rigidbody2D>();

        // rb.velocity = (pointC.position - pointB.position) * speed * Time.deltaTime;
        // centerPoint = Vector3.Lerp(pointB.position, pointC.position, 0.5f);
        // distant = Vector2.Distance(pointB.position, pointC.position);

        rate = 1 / duration;

        // StartCoroutine(WaitAndMove(Random.Range(1, 2)));
    }

    // IEnumerator WaitAndMove(int time)
    // {
    //     while (true)
    //     {
    //         if (isAtB)
    //         {
    //             yield return new WaitForSeconds(time);
    //             Debug.Log("Delay after " + time + "s");
    //             isCanReturn = true;
    //             break;
    //         }

    //         yield return null;
    //     }

    // }

    // Update is called once per frame
    void Update()
    {
        // Exam 1

        // transform.Translate((pointB.position - pointA.position) * speed * Time.deltaTime);
        // transform.position = Vector3.MoveTowards(transform.position, pointB.position, Time.deltaTime * speed);

        // Exam 2

        // if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        // {
        //     car.transform.position = pointA.position;
        // }

        // Exam 3
        // if (!isAtB)
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointB.position, Time.deltaTime * speed);
        // }

        // if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        // {
        //     isAtB = true;
        // }

        // if (isAtB)
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointC.position, Time.deltaTime * speed);
        // }

        // if (Vector2.Distance(car.position, pointC.position) < 0.1f)
        // {
        //     car.transform.position = pointA.position;
        //     isAtB = false;
        // }

        //Exam 4

        // car.transform.position = Vector3.Slerp(pointA.position, pointB.position, time / Vector2.Distance(car.position, pointC.position));
        // time += Time.deltaTime;

        //Exam 5
        // if (!isAtB)
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointB.position, Time.deltaTime * speed);
        // }
        // else
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointA.position, Time.deltaTime * speed);
        // }

        //Exam7

        // if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        // {
        //     isAtB = true;
        // }

        //Exam 9

        // time += rate * Time.deltaTime;
        // car.transform.position = Vector3.Lerp(pointA.position, pointB.position, time);


        //Exam 10
        // if (!isAtB)
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointB.position, Time.deltaTime * speed);
        // }

        // if (isCanReturn)
        // {
        //     car.transform.position = Vector3.MoveTowards(car.transform.position, pointA.position, Time.deltaTime * speed);
        // }

        // if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        // {
        //     isAtB = true;
        // }

        //Exam 12


    }
}
