using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class LoopsAndArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Activity 1
        int[] integers = new int[3];
        int[] integers2 = new int[3];

        for (int i = 0; i < integers.Length; i++)
        {
            integers[i] = Random.Range(0, 10);
            integers2[i] = Random.Range(0, 10);
        }
        int[] integers3 = new int[3];

        for (int i = 0; i < integers.Length; i++)
        {
            integers3[i] = integers[i] + integers2[i];
        }

        for (int i = 0; i < integers3.Length; i++)
        {
            Debug.Log("Integers 1: " + integers[i]);
            Debug.Log("Integers 2: " + integers2[i]);
            Debug.Log("Integers 3: " + integers3[i]);
        }

        //Activity 2
        string[] strings =
        {
            "Prueba",
            "Array",
            "de",
            "strings",
            "en",
            "C#"
        };
        string linkedString = "";
        foreach (string str in strings)
        {
            linkedString += " " + str;
        }
        linkedString = linkedString.Trim();
        Debug.Log(linkedString);

        //Activity 3

        //Tested for any "mxn" dimensions

        const int SHARED_LENGTH = 4;
        const int SHARED_RESULT_VECTOR_LENGTH = 3;
        int[,] matrix= new int[SHARED_RESULT_VECTOR_LENGTH, SHARED_LENGTH] { 
            {1,2,3,1}, 
            {4,5,6,1},
            {6,7,9,1}
        };
        int[] vector = new int[SHARED_LENGTH] { 5, 6, -8, 0};
        int[] resultVector = new int[SHARED_RESULT_VECTOR_LENGTH];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int sum = 0;
            for (int j = 0; j < SHARED_LENGTH; j++)
            {
                sum += matrix[i, j] * vector[j];
            }
            resultVector[i] = sum;
        }

        for(int i = 0; i < resultVector.Length; i++)
        {
            Debug.Log(resultVector[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
