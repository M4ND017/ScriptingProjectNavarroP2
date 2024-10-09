using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandFunctions : MonoBehaviour
{
    //Create a variable of type int and set to number 5
    int myInt = 10;


    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 2;
            return result; 
    }
}
