using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FunctionExercise4 : MonoBehaviour {
    // First read the code and figure out what this is going to print, and only then run the game to check.

    void removeFirstTwo(List<int> array)
    {
        array.RemoveAt(0);
        array.RemoveAt(0);
    }

    void Start()
    {
        List<int> array = new List<int>(); // creating list as empty
        array.Add(3);
        array.Add(5);
        array.Add(6);
        array.Add(8);
        array.Add(10);

        removeFirstTwo(array);

        string s = "";
        foreach (int i in array)
        {
            s += i;
            s += " ";
        }
        print(s);
    }

}