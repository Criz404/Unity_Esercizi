using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Lab3_Es11 : MonoBehaviour
{
    [Range(0,10)]
    public float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        switch(score)
        {
            case >=10:
                Debug.Log("A+");
                break;
            case >= 9:
                Debug.Log("A");
                break;
            case >= 7:
                Debug.Log("B");
                break;
            case >= 6:
                Debug.Log("C");
                break;
            case >= 5:
                Debug.Log("E");
                break;
            case >= 0:
                Debug.Log("F");
                break;
            default:
                Debug.Log("Voto non valido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
