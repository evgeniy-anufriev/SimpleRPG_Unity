using UnityEngine;
using System.Collections;
using System.Reflection;
using System;
using System.Collections.Generic;

public class Movement : MonoBehaviour {
    public static System.Random rand = new System.Random();
    // Use this for initialization
    public Vector3 vector = new Vector3();
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            vector.x = 0f;
            vector.z = 0.1f;
            vector.y = 0f;
            gameObject.transform.localPosition = gameObject.transform.localPosition + vector;

        }

        if (Input.GetKey(KeyCode.S))
        {
            vector.x = 0f;
            vector.z = -0.1f;
            vector.y = 0f;
            gameObject.transform.localPosition = gameObject.transform.localPosition + vector;
        }

        if (Input.GetKey(KeyCode.A))
        {
            vector.z = 0f;
            vector.x = -0.1f;
            vector.y = 0f;
            gameObject.transform.localPosition = gameObject.transform.localPosition + vector;
        }

        if (Input.GetKey(KeyCode.D))
        {
            vector.z = 0f;
            vector.x = 0.1f;
            vector.y = 0f;
            gameObject.transform.localPosition = gameObject.transform.localPosition + vector;
        }

    }







}
