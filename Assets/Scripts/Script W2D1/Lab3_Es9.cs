using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es9 : MonoBehaviour
{
    public int a = 3;
    public int b = 5;
    void Start()
    {
        MinoreTra2();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void MinoreTra2()
    {
        if (a < b)
        {
            Debug.Log(a);
        }
        else
        {
            Debug.Log(b);
        }
    }
}
