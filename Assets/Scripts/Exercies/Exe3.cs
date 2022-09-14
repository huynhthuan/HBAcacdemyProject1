using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exe3 : MonoBehaviour
{
    Rigidbody2D rb;
    Vector3 target;
    public Camera cameraMain;
    public Transform car;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            target = cameraMain.ScreenToWorldPoint(Input.mousePosition);
            rb.velocity = (target - car.transform.position) * 50 * Time.deltaTime;
        }

        if (Vector2.Distance(car.transform.position, target) < 0.01f)
        {
            car.transform.position = target - cameraMain.transform.position;
        }
    }
}
