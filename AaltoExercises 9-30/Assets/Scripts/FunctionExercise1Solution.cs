using UnityEngine;
using System.Collections;

public class FunctionExercise1Solution : MonoBehaviour {

    void timesTwo(int num1)
    {
        int result = num1 * 2;
        print(result);
    }

    void Start()
    {
        timesTwo(3);
    }
}
