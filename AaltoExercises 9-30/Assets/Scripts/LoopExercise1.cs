using UnityEngine;
using System.Collections;

// Basic while-loop.
// First read the code and figure out what this is going to print, and only then run the game to check.

public class LoopExercise1 : MonoBehaviour {

	void Start () {

		int j = 0;
		while (j < 5) {
			Debug.Log (j);
			j = j + 1;
		}
	}
}
