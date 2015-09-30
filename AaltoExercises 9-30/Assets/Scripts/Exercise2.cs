using UnityEngine;
using System.Collections;

public class Exercise2 : MonoBehaviour {

    void AddTwo(float number) {
        Debug.Log(number + 2);
    }

	void Start () {
        float number1 = 50;
        AddTwo(number1);
        Debug.Log(number1);
	}
}