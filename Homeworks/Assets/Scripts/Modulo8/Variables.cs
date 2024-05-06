using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Part 1
    int integerVariable = 1;
    float floatVariable = 1.54321f;
    public GameObject cube;
    public string testColor;
    public string fullName = "Mauricio Espinosa Flores";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Activity 1
        integerVariable *= 2;
        Debug.Log("Integer variable: " + integerVariable);
    }

    private void FixedUpdate()
    {
        //Activity 1
       floatVariable *= 1.01f;
       Debug.Log("Float variable: " + floatVariable);

        //Activity 2
        int explicitCasting = (int)(floatVariable + 0.5f);
        Debug.Log("Integer Value from casting: " + explicitCasting);

        //Activity 3
       GetComponent<MeshRenderer>().material.color = (int)floatVariable % 2 == 0 ? Color.red : Color.green;


        //Activity 4
        switch (testColor.ToLower())
        {
            case "red":
                cube.GetComponent<MeshRenderer>().material.color = Color.red;
                break;
            case "blue":
                cube.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
            case "green":
                cube.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            default:
                cube.GetComponent<MeshRenderer>().material.color = Color.yellow;
                break;
        }


        //Activity 5
       string fixedDecimal = floatVariable.ToString("N4");
       Debug.Log("Fixed Decimal: " + fixedDecimal);


        //Activity 6, only substrings
        string firstName = fullName.Substring(0, fullName.IndexOf(' '));
        Debug.Log("First Name: " + firstName);

        string familyName = fullName.Substring(fullName.IndexOf(' '), fullName.LastIndexOf(' ') - fullName.IndexOf(' ')+1);
        Debug.Log("Family Name: " + familyName);
        string lastName = fullName.Substring(fullName.LastIndexOf(' '));
        Debug.Log("Last Name: " + lastName);

        string[] splittedName = fullName.Split(' ');
        
        foreach (var word in splittedName)
        {
            Debug.Log($"Substring: {word}");
        }



        //PART 2

        //Activity 1
        string number1 = "1";
        string number2 = "2";


        if (!int.TryParse(number1, out int number1AuxValue))
        {
            Debug.LogError("number1 and number2 must be a valid number");
        }
        if (!int.TryParse(number2, out int number2AuxValue))
        {
            Debug.LogError("number1 and number2 must be a valid number");
        }
        
        Debug.Log("Sum: " + (number1AuxValue + number2AuxValue));

        //Activity 2
       string sentence = "Happy Nation, Living in a Happy Nation";

       for(int i = 0; i < sentence.Length; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(sentence[i]);
            }
        }

        //Activity 3
        string lastStringVariable = "Pedro pedro pedro pedro pe";
        Debug.Log(lastStringVariable.Substring(0, lastStringVariable.Length - 5));
    }
}
