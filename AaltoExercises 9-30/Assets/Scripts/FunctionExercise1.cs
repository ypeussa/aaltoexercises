using UnityEngine;
using System.Collections;

public class FunctionExercise1 : MonoBehaviour {
    // First read the code and figure out what this is going to print, and only then run the game to check.

    void AddTwo(float number1) {
        number1 += 2;
        print(number1);
    }

    void Start() {
        float number1 = 2.0f;
        float number2 = 3.0f;
        AddTwo(number2);
        print(number2);
    }
}
