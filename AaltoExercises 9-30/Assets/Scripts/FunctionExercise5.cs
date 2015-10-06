using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FunctionExercise5 : MonoBehaviour {

    // First read the code and figure out what this is going to print, and only then run the game to check.

    void AddTwo(float f)
    {
        f += 2;
        print(f);
    }

    void Start()
    {
        float number = 3.0f;
        AddTwo(number);
        print(number);
    }
}