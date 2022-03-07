using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 start;
    Vector3 Current;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move forword if press w
        if (Input.GetKeyDown(KeyCode.W))
        {
            Vector3 start = transform.eulerAngles;
            start.x = 0;
            start.y = 0;
            start.z = 0;
            transform.eulerAngles = start;
            transform.Translate(0f, 0f, -1f);
        }
        // turn back and move forword if press s
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 Current = transform.eulerAngles;
            Current.x = 0;
            Current.y = 180;
            Current.z = 0;
            transform.eulerAngles = Current;
            transform.Translate(0f, 0f, -1f);
        }
        // turn left and move forword if press a
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 Current = transform.eulerAngles;
            Current.x = 0;
            Current.y = -90;
            Current.z = 0;
            transform.eulerAngles = Current;
            transform.Translate(0f, 0f, -1f);
        }
        // turn right and move forword if press d
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 Current = transform.eulerAngles;
            Current.x = 0;
            Current.y = 90;
            Current.z = 0;
            transform.eulerAngles = Current;
            transform.Translate(0f, 0f, -1f);
        }
    }
}
