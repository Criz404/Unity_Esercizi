using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Lab3_Es5 : MonoBehaviour
{
    public int num = 9;
    // Start is called before the first frame update
    void Start()
    {
        
        if (num % 2 == 0)
        {
            Debug.Log(num + " è pari!");
        }
        else
        {
            Debug.Log(num + " è dispari!");
        }

        if (num > 10)
        {
            Debug.Log(num + " è maggiore di 10!");
        }
        else
        {
            Debug.Log(num + " è minore di 10!");
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
