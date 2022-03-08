/****
 * Created by: Ruoyu Zhang
 * Data Created: Mar 5, 2022
 * 
 * Last Edited by: Mar 7, 2022
 * Last Edited: Mar 7, 2022
 * 
 * Description: Create the goal of the game
 */

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
    }
}
