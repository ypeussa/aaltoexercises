using UnityEngine;
using System.Collections;

// Foreach loop
// First read the code and figure out what this is going to print, and only then run the game to check.

public class LoopExercise3 : MonoBehaviour {

	int[] intArray = new int[] { 0, 1, 2, 3, 4 };
	
	void Start () {

		int count = 0;
		foreach (int element in intArray) {
			Debug.Log (intArray[count]);
			count++;
		}	
	}
}
