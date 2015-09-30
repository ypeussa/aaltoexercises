using UnityEngine;
using System.Collections;

public class Exercise3 : MonoBehaviour {

    void DivideByTwo(int numberToDivide) {
        Debug.Log(numberToDivide / 2);
    }

    void AnotherDivideByTwo(int numberToDivide)
    {
        Debug.Log(numberToDivide / 2.0f);
    }

    void ThirdDivideByTwo(float numberToDivide) {
        Debug.Log(numberToDivide / 2);
    }


    void Start () {
        int number1 = 9;
        DivideByTwo(number1);
        AnotherDivideByTwo(number1);
        ThirdDivideByTwo(number1);
	}
}