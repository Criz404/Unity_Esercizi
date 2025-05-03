using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es3 : MonoBehaviour
{
    //Due modi per esporre una variabile nell'ispector

    public int num = 5; //dichiare una variabile public

    [SerializeField] //Utilizzare SerializeField
    private double num2 = 2.5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
