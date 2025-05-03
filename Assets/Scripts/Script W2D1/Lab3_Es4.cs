using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es4 : MonoBehaviour
{
    public int n1=4, n2=5, n3=3, n4=6;
    // Start is called before the first frame update
    void Start()
    {
        int sum = n1 + n2 + n3 + n4;
        Debug.Log(sum);
        int prod = n1 * n2 * n3 * n4;
        Debug.Log(prod);
        float average = sum / 4f;
        Debug.Log(average.ToString("F2"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
