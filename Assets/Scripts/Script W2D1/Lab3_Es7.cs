using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lab3_Es7 : MonoBehaviour
{
    public int startingNum = 3;
    void Start()
    {
        Stampa2Precedenti();
    }


    void Update()
    {

    }

    void Stampa2Precedenti()
    {
        Debug.Log("Partenza -> " + startingNum + " successivo -> " + (startingNum - 1).ToString() + " successivo -> " + (startingNum - 2).ToString());
    }
}
