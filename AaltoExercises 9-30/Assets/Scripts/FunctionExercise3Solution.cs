using UnityEngine;
using System.Collections;

public class FunctionExercise3Solution : MonoBehaviour {

    float Subtract(float a, float b)
    {
        float result = a - b;
        return result;
    }

    void Start()
    {
        float result = Subtract(4.0f, 3.1f);
        print(result);
    }
}
