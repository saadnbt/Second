using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonAiming : MonoBehaviour
{
    float a = 1f, aa = 0f;
   
    void Start()
    {
        
    }

    
    void Update()
    {
       if (aa < 10f && Input.GetKeyDown(KeyCode.H)) { transform.Rotate(a, 0, 0); aa += a; } 
       if (aa >= -.1f && Input.GetKeyDown(KeyCode.L)) { transform.Rotate(-a, 0, 0); aa -= a; }
    }
}
