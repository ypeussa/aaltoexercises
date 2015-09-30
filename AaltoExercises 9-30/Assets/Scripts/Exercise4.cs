using UnityEngine;
using System.Collections;

public class Exercise4 : MonoBehaviour {

    void DoubleThis(float number1){
        number1 *= 2;
        Debug.Log(number1);
    }

    void Start () {
        float number1 = 6.0f;
        float number2 = 12.0f;
        DoubleThis(number2);
        DoubleThis(number2);
	}
}