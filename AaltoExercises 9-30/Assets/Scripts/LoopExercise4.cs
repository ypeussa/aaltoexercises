using UnityEngine;
using System.Collections;

// One more for-loop, this time modifying things.
// First read the code and figure out what this is going to print, and only then run the game to check.

public class LoopExercise4 : MonoBehaviour {

	public int number = 10;
	int[] intArray = new int[] { 0, 1, 2, 3, 4 };

	void Start () {

		for (int i = 0; i < intArray.Length; i++) {
			intArray[i] += number;
			Debug.Log (intArray[i]);
		}
	}
}
