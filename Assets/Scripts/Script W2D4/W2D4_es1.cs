using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2D4_es1 : MonoBehaviour
{
    
    public int num=0;
    public int index=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (index > 0)
        {
            num++; 
            Debug.Log("Varibile num: " + num);
            index--;

        }
    }
}
