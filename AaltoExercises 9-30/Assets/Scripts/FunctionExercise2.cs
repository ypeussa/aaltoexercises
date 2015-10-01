using UnityEngine;
using System.Collections;

public class FunctionExercise2 : MonoBehaviour {
    // First read the code and figure out what this is going to print, and only then run the game to check.

    float number1 = 5.0f;
    float number2 = 13.0f;

    float MyFunction(float number) {
        number += number2;
        print(number);
        return number;
    }

    void Start() {
        MyFunction(MyFunction(number1));
    }
}
