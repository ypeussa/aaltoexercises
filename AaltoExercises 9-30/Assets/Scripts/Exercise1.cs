using UnityEngine;
using System.Collections;

public class Exercise1 : MonoBehaviour {

    void AddTwo(float number) {
        Debug.Log(number + 2);
    }

	void Start () {
        float number1 = 10.0f;
        float number2 = 7.0f;
        AddTwo(number1 + number2);
	}
}