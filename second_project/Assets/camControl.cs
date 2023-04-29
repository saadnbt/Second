using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Comma)) {transform.position=(new Vector3(0f, 3f, -3f)); }
        if (Input.GetKeyDown(KeyCode.Period)) {transform.position=(new Vector3(0f, 30f, -180f)); }
    }
}
