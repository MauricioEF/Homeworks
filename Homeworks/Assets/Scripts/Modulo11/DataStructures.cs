using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStructures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Activity 1
        Debug.Log("Activity 1 Logs start here");
        var newList = CreateIntegersList(3, 10, 20);
        foreach(int number in newList)
        {
            Debug.Log(number);
        }


        //Activity 2
        Debug.Log("Activity 2 Logs start here");
        var myArray = new int[5] { 10, 24, -1, 3, 2 };
        var reversedArray = DescendingSort(myArray);
        for(int i = 0; i < reversedArray.Length; i++)
        {
            Debug.Log(reversedArray[i]);
        }

        //Activity 3
        Debug.Log("Activity 3 Logs start here");
        //Linq or Contains not necessary at this point, when we create a Hash from a List, it always removes duplicated elements automatically
        List<string> myStrings = new List<string>
        {
            "Element1",
            "Element1",
            "Element1",
            "Element1",
            "Element1",
            "Element2",
            "Element3",
            "Element2"
        };
        HashSet<string> hashSet = RemoveDuplicates<string>(myStrings);
        foreach(string s in hashSet)
        {
            Debug.Log(s);
        }


        //Activity 4
        Debug.Log("Activity 4 Logs start here");
        Stack<string> myStack = new Stack<string>();
        myStack.Push("Element 1");
        myStack.Push("Element 2");
        myStack.Push("Element 3");
        myStack.Push("Element 4");
        myStack.Push("Element 5");
        ShowQueueElementsFromStack(myStack);
    }

    public List<int> CreateIntegersList(int size,int min, int max)
    {
        var customList = new List<int>();
        for(int i = 0; i < size; i++)
        {
            customList.Add(UnityEngine.Random.Range(min, max));
        }
        return customList;
    }

    public int[] DescendingSort(int[] arrayExample)
    {
        var arrayCopy = new int[arrayExample.Length];

        arrayExample.CopyTo(arrayCopy, 0);

        Array.Sort(arrayCopy);
        Array.Reverse(arrayCopy);

        return arrayCopy;
    }

    public HashSet<T> RemoveDuplicates<T>(List<T> list)
    {
        return new HashSet<T>(list);
    }
    
    public void ShowQueueElementsFromStack(Stack<string> stack)
    {
        Queue<string> myQueue = new Queue<string>();
        Debug.Log(stack.Count);
        do
        {
            var stackElement = stack.Pop();
            Debug.Log(stackElement);
            myQueue.Enqueue(stackElement);
        }while(stack.Count > 0);

        do
        {
            Debug.Log(myQueue.Dequeue());
        }while(myQueue.Count > 0);
    }
}
