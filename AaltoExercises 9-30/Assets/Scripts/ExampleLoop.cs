using UnityEngine;
using System.Collections;

// You can use this to test the behavior of the for loop.
// Change the value of the Count To number directly from the Unity editor before
// starting the game.

public class ExampleLoop : MonoBehaviour {

	public int countTo = 10;

	void Start () {

		for (int i = 0; i <= countTo; i++) {
			print (i);
		}
	}
}
