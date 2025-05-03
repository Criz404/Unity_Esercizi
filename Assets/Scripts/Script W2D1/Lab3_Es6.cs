using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es6 : MonoBehaviour
{
    public int startingNum = 1;
    void Start()
    {
        Stampa2Successivi();
    }

    
    void Update()
    {
        
    }

    void Stampa2Successivi()
    {
        Debug.Log("Partenza -> " + startingNum + " successivo -> " + (startingNum + 1).ToString() + " successivo -> " + (startingNum + 2).ToString());
    }
}
