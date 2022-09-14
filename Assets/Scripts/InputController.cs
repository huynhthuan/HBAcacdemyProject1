using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public float speed = 10f;
    public Camera cameraMain;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Exam 6

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cameraMain.ScreenPointToRay(cameraMain.ScreenToWorldPoint(Input.mousePosition));

            RaycastHit hit;

            // Debug.Log(Physics.Raycast(ray, out hit));
            // Debug.Log(Input.mousePosition);
            // Debug.Log(cameraMain.ScreenToWorldPoint(Input.mousePosition));
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);

            if (Physics.Raycast(ray, out hit))
            {
                hit.transform.GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }
}
