using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es8 : MonoBehaviour
{
    public int a = 3;
    public int b = 5;
    void Start()
    {
        MaggioreTra2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MaggioreTra2()
    {
        if(a>b)
        {
            Debug.Log(a);
        }
        else
        {
            Debug.Log(b);
        }
    }
}
