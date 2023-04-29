using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketing : MonoBehaviour
{
    /**/public AudioSource source; 

    float dis = 0, stp = 9f;



    void Start()
    {
        /**/source = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {transform.Translate(0,0, stp); dis+=stp; /*source.PlayOneShot(clip2);*/}
        if (Input.GetKeyUp(KeyCode.Space)) {transform.Translate(0,0, -dis); dis = 0f; /*source.PlayOneShot(clip2);*/}
    }
}
