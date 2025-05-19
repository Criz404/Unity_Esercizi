using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class W2D4_Es2 : MonoBehaviour
{
    public int[] arr = new int[4];
    public int sum=0;
    public int prod=1;
    // Start is called before the first frame update
    void Start()
    {
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        for (int i = 0; i < 4; i++)
        {
            sum += arr[i];
            Debug.Log("somma " + sum);
            prod *= arr[i];
            Debug.Log("prodotto " + prod);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
