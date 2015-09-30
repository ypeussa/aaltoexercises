using UnityEngine;
using System.Collections;

// You can use this to test the behavior of the if-elseif-else statements.
// Change the values of the numbers directly from the Unity editor before
// starting the game.

public class ExampleIfElseIf : MonoBehaviour {

    public float number1;
    public float number2;

    void Start () {
        if (number1 < number2) {
			Debug.Log ("Number 2 is bigger");
		}
		else if (number1 > number2) {
			Debug.Log ("Number 2 is smaller");
		}
        else {
            Debug.Log("Numbers are equal");
		}
	}
}