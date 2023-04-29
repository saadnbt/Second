using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTank : MonoBehaviour
{ 
    float horizontalInput, verticalInput, speed=1f;

    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal") * 40f * Time.deltaTime; 
        verticalInput = Input.GetAxis("Vertical")     * 10 * Time.deltaTime; 

        transform.Translate(new Vector3(0,0,verticalInput*speed));
        transform.Rotate(0, horizontalInput*speed, 0);

        if (Input.GetKeyDown(KeyCode.Period)) speed *= 1.5f;
        if (Input.GetKeyDown(KeyCode.Comma)) speed /= 1.5f;



    }
}
