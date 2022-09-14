using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exam10 : MonoBehaviour
{
    public Transform car;
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    private bool isAtB = false;
    public float speed = 2f;
    float timeDelay = 0;
    bool isCanReturn = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndMove(Random.Range(1, 4)));
    }

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

        if (isCanReturn)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                pointA.position,
                Time.deltaTime * speed
            );
        }

        if (Vector2.Distance(car.position, pointB.position) < 0.1f)
        {
            isAtB = true;
        }
    }

    IEnumerator WaitAndMove(int time)
    {
        while (true)
        {
            if (isAtB)
            {
                yield return new WaitForSeconds(time);
                Debug.Log("Delay after " + time + "s");
                isCanReturn = true;
                break;
            }

            yield return null;
        }
    }
}
