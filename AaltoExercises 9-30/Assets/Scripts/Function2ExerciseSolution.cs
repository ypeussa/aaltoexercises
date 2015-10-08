using UnityEngine;
using System.Collections;

public class Function2ExerciseSolution : MonoBehaviour {
    void checkNumber(int number)
    {
        if (number < 10)
        {
            print("Pretty small");
        }
        else
        {
            print("A nice number");
        }
    }

    void Start()
    {
        checkNumber(6);
        checkNumber(11);
    }
}
