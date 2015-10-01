using UnityEngine;
using System.Collections;

//---

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
